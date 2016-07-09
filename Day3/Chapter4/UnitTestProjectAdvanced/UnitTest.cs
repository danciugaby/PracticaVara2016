using System;
using LambdaExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoreDelegatesAndEvents;

namespace UnitTestProjectAdvanced
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestGenericDelegates()
        {
            MoreDelegatesAndEvents.Point[] vals = new Point[3];
            vals[0] = new Point();
            vals[0].X = 1;
            vals[1] = new Point();
            vals[1].Y = 1;
            vals[2] = new Point();
            //its like having an interface without having to plug the 
            //"interface" physic connection
           GenericDelegate<CallerForDelegate>.Transform(vals, CallerForDelegate.ATransformer);

        }

        static void stock_PriceChanged(object sender, PriceChangedEventArgs e)
        {
            if ((e.NewPrice - e.LastPrice) / e.LastPrice > 0.1M)
                Console.WriteLine("Alert, 10% stock price increase!");
        }

        [TestMethod]
        public void TestEvents()
        {
            Stock stock = new Stock("THPW");
            try
            {
                stock.Price = 27.10M;
            }
            catch (Exception ex)
            {
             Console.WriteLine(ex.Message);   
            }
           
            // Register with the PriceChanged event
            //the register
            stock.PriceChanged += stock_PriceChanged;
            stock.Price = 31.59M;
        }
        
        [TestMethod]
        public void TestLambdaExpressions()
        {
            LEinDelegates.ExampleLE();
            LEinDelegates.QueryOperator();
            LEinDelegates.MoreQueries();
        }
    }
    
}
