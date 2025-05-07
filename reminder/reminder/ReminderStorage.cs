using Newtonsoft.Json;
using reminder;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web.UI.WebControls;
using System.Windows.Forms;

public static class ReminderStorage
{
    // Tüm hatırlatıcıları döndüren fonksiyon
    public static List<Reminder> GetAll()
    {
        return Load();  // JSON'dan tüm hatırlatıcıları al
    }

    private static readonly string FilePath = "reminders.json";

    public static List<Reminder> Load()
    {
        if (!File.Exists(FilePath))
            return new List<Reminder>();

        string json = File.ReadAllText(FilePath);
        return JsonConvert.DeserializeObject<List<Reminder>>(json);
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
            // Bu örnekte sadece IsCompleted güncelleniyor, istersen diğer alanları da güncelleyebilirsin
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
        // Tüm hatırlatıcıları al
        var reminders = ReminderStorage.GetAll();  // Bu fonksiyon, hatırlatıcıları JSON'dan alır

        foreach (var reminder in reminders)
        {
            // Eğer hatırlatıcı süresi geçmişse, tamamlanmış olarak işaretle
            if (reminder.DateTime < DateTime.Now)
            {
                reminder.IsCompleted = true;
                
                // ReminderStorage içinde güncelle
                ReminderStorage.Update(reminder);
            }
        }
    }



}
