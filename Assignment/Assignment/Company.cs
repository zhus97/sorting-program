using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Company : IComparable, IEnumerable
    {
        public string name { get; set; }
        public int netIncome { get; set; }
        public int operatingIncome { get; set; }
        public int totalAssets { get; set; }
        public int numEmployees { get; set; }
        public LinkedList<string> buyers { get; set; }

        public int CompareTo(object other)
        {
            Company temp = (Company)other;
            return name.CompareTo(temp.name);
        }

        public Company (string name, int netIncome, int operatingIncome, int totalAssets, int numEmployees, LinkedList<String> buyers)
        {
            this.name = name;
            this.netIncome = netIncome;
            this.operatingIncome = operatingIncome;
            this.totalAssets = totalAssets;
            this.numEmployees = numEmployees;
            this.buyers = buyers;
        }

        public override string ToString()
        {
            return name;
            
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
