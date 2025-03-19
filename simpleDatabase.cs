using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul5_103022300066
{
    class simpleDatabase<T>
    {
        public List<T> storedData;
        public List<DateTime> inputDate;

        public simpleDatabase()
        {
            storedData = new List<T>();
            inputDate = new List<DateTime>();
        }

        public void addData(T data)
        {
            storedData.Add(data);
            inputDate.Add(DateTime.Now);
        }

        public void printaAllData()
        {
            for (int i = 0; i < storedData.Count; i++)
            {
                Console.WriteLine("Data: " + storedData[i] + " | Date: " + inputDate[i]);
            }
        }
    }
}
