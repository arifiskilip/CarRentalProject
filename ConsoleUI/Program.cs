using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Context;
using System;
using System.Linq;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
        
        }

        void ChechkRental()
        {
            using (var context = new CarRentalContext())
            {
                var data = context.Rentals.ToList();
                var x = data.FirstOrDefault(x=> x.CarId== 1);
            }
        }
    }
}
