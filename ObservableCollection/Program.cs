using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace ObservableCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            ObservableCollection<string> presidents = new
                ObservableCollection<string>
            {
                "Jimmy Carter",
                "Ronald Reagan",
                "George HW Bush"
            };

            //creating current action notification
            presidents.CollectionChanged += OnCollectionChanged;

            presidents.Add("Bill Clinton");
            presidents.Remove("Jimmy Carter");

            foreach (string president in presidents)
                Console.WriteLine(president);
        }

        //providing data for the notification
        static void OnCollectionChanged(object sender,
            NotifyCollectionChangedEventArgs e)
        {
        }
    }
}
