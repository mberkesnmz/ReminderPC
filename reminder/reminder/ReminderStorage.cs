﻿using Newtonsoft.Json;
using reminder;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

public static class ReminderStorage
{
    private static readonly string AppDataDir = Path.Combine(
        Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
        "ReminderApp");

    private static readonly string FilePath = Path.Combine(AppDataDir, "reminders.json");
    private static readonly string DefaultRemindersPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "reminders.json");

    // Tüm hatırlatıcıları döndüren fonksiyon
    public static List<Reminder> GetAll()
    {
        return Load();
    }

    public static List<Reminder> Load()
    {
        if (!Directory.Exists(AppDataDir))
            Directory.CreateDirectory(AppDataDir);

        if (!File.Exists(FilePath) && File.Exists(DefaultRemindersPath))
        {
            File.Copy(DefaultRemindersPath, FilePath);
        }

        if (!File.Exists(FilePath))
            return new List<Reminder>();

        string json = File.ReadAllText(FilePath);
        return JsonConvert.DeserializeObject<List<Reminder>>(json) ?? new List<Reminder>();
    }

    public static void Save(List<Reminder> reminders)
    {
        string json = JsonConvert.SerializeObject(reminders, Formatting.Indented);
        File.WriteAllText(FilePath, json);
    }

    public static void Update(Reminder updatedReminder)
    {
        var reminders = Load();

        var existing = reminders.FirstOrDefault(r =>
            r.Title == updatedReminder.Title &&
            r.Description == updatedReminder.Description &&
            r.DateTime == updatedReminder.DateTime);

        if (existing != null)
        {
            existing.IsCompleted = updatedReminder.IsCompleted;
            Save(reminders);
        }
    }

    public static void Delete(Reminder reminderToDelete)
    {
        var reminders = Load();

        var toRemove = reminders.FirstOrDefault(r =>
            r.Title == reminderToDelete.Title &&
            r.Description == reminderToDelete.Description &&
            r.DateTime == reminderToDelete.DateTime);

        if (toRemove != null)
        {
            reminders.Remove(toRemove);
            Save(reminders);
        }
    }

    public static void UpdateCompletedReminders()
    {
        var reminders = GetAll();

        foreach (var reminder in reminders)
        {
            if (reminder.DateTime < DateTime.Now)
            {
                reminder.IsCompleted = true;
                Update(reminder);
            }
        }
    }
}
