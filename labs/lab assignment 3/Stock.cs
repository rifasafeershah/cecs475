using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.IO;

namespace Stock
{
    public class Stock
    {
        public event EventHandler<StockNotification> StockEvent;

        private readonly Thread _thread;

        public static ReaderWriterLockSlim myLock = new ReaderWriterLockSlim();

        // public static readonly docPath = Environment.CurrentDirectory + @"\Lab3_Output.txt";

        public static string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        public static readonly string title = "Date and Time".PadRight(30) + "Stock".PadRight(15) + "Initial Value".PadRight(15) + "Price";

        public string StockName { get; set; }
        public int InitialValue { get; set; }
        public int CurrentValue { get; set; }
        public int MaxChange { get; set; }
        public int Threshold { get; set; }
        public int NumChanges { get; set; }

        /// <summary>
        ///     Stock class that contains all the information and changes of the stock
        /// </summary>
        /// <param name="name">Stock name</param>
        /// <param name="startingValue">Starting stock value</param>
        /// <param name="maxChange">The max value change of the stock</param>
        /// <param name="threshold">The range for the stock</param>
        public Stock(string name, int startingValue, int maxChange, int threshold)
        {
            StockName = name;
            InitialValue = startingValue;
            CurrentValue = startingValue;
            MaxChange = maxChange;
            Threshold = threshold;
            _thread = new Thread(new ThreadStart(Activate));
            _thread.Start();
            //this.StockEvent += EventHandler;
        }

        /// <summary>
        ///     Activates the threads synchronizations
        /// </summary>
        public void Activate()
        {
            for (int i = 0; i < 25; i++)
            {
                Thread.Sleep(500); // 1/2 second
                ChangeStockValue();
                //StockEvent(this, null);
            }
        }

        /// <summary>
        ///     Changes the sotck value and also raising the event of stock value changes
        /// </summary>
        public void ChangeStockValue()
        {
            var rand = new Random();
            CurrentValue += rand.Next(0, MaxChange + 1);
            NumChanges++;
            if ((CurrentValue - InitialValue) > Threshold)
            {
                StockEvent?.Invoke(this, new StockNotification(this.StockName,this.CurrentValue,this.NumChanges));
            }
        }
        public event EventHandler<StockNotification> StockNotification;
    }
}
