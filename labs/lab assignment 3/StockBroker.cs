using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading;

//using System.Exception;

namespace Stock
{
    public class StockBroker
    {
        public string BrokerName { get; set; }

        public List<Stock> stocks = new List<Stock>();

        public static ReaderWriterLockSlim myLock = new ReaderWriterLockSlim();
        readonly string docPath = @"Lab3.txt";

        public string titles = "Broker".PadRight(10) + "Stock".PadRight(15) + "Value".PadRight(10) + "Changes".PadRight(10) + "Date and Time";

        /// <summary>
        ///     The stockbroker object
        /// </summary>
        /// <param name="brokerName">The stockbroker's name</param>
        public StockBroker(string brokerName)
        {
            BrokerName = brokerName;
        }

        /// <summary>
        ///     Adds stock objects to the stock list 
        /// </summary>
        /// <param name="stock">Stock object</param>
        public void AddStock(Stock stock)
        {
            stocks.Add(stock);
            stock.StockEvent += EventHandler;
        }

        /// <summary>
        ///     The eventhandler that raises the event of a change 
        /// </summary>
        /// <param name="sender">The sender that indicated a change</param>
        /// <param name="e">Event arguments</param>
        public void EventHandler(Object sender, StockNotification e)
        {
            myLock.EnterWriteLock();

            try
            {
                //e.StockName.PadRight(15), e.CurrentValue, e.NumChanges);

                Stock newStock = (Stock)sender;
                //e = new StockNotification();
                //Console.WriteLine(BrokerName.PadRight(10));

                if (!File.Exists(docPath))
                {
                    // Create a new file.
                    using (StreamWriter sw = File.CreateText(docPath))
                    {
                        sw.WriteLine(titles);
                    }

                }
                // This text is always added, making the file longer over time
                // if it is not deleted.
                using (StreamWriter sw = File.AppendText(docPath))
                {
                    //Write the event data to the file
                    sw.WriteLine(BrokerName.PadRight(10)+ e.StockName.PadRight(15) +e.CurrentValue.ToString().PadRight(10) + e.NumChanges.ToString());
                    //+ e.StockName.PadRight(15) +e.CurrentValue.ToString().PadRight(10) + e.NumChanges.ToString()

                }
            }
            finally
            {
                myLock.ExitWriteLock();
            }
        }    
    }
}