using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4_1302200018
{
     class Program
    {
         static void Main(string[]args)
        {
            Console.WriteLine(Penjumlahan.JumlahTigaAngka<double>(13, 02, 20));
            SimpleDataBase<int> data = new SimpleDataBase<int>();
            data.AddNewData(13);
            data.AddNewData(02);
            data.AddNewData(20);
            data.printAllData();

        }
    }

    class  Penjumlahan 
    {
        public static T JumlahTigaAngka <T> (T inputsatu, T inputdua, T inputtiga)
        {
            dynamic jumlah1 = inputsatu;
            dynamic jumlah2 = inputdua;
            dynamic jumlah3 = inputtiga;

            return jumlah1 + jumlah2 + jumlah3;

        }

    }
    class SimpleDataBase<T>
    {
        private List<T> storedData;
        private List<DateTime> inputDates;
        public SimpleDataBase()
        {
            storedData = new List<T>();
            inputDates = new List<DateTime>();
        }

        public void AddNewData(T data)
        {
            storedData.Add(data);
            inputDates.Add(DateTime.Now);
        }

        public void printAllData()
        {
            for (int i = 0; i < storedData.Count; i++)
            {
                Console.WriteLine("data" + i + "isi :" + storedData[i].ToString() + "disimpan pada waktu" + i);
            }
        }
    }
}
   
