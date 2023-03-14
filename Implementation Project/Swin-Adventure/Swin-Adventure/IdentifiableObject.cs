using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwinAdventure
{
    public class IdentifiableObject
    {
        private List<string> _identifiers;
        public  IdentifiableObject(string[] idents)
        {
            _identifiers = new List<string>();
            _identifiers.AddRange(idents);
        }
        public bool AreYou(string id)
        {
            foreach(string c in _identifiers) 
            {
                if (c.ToLower() == id.ToLower())
                {
                    Console.WriteLine("True");
                    return true;
                }
            }
            Console.WriteLine("False");
            return false;
        }
        public string FirstId
        { 
            get
            {
                if (_identifiers.First() == null) return ""; 
                else return _identifiers.First();
            }
        }
        public void AddIdentifier(string id)
        {
            int i = 0;
            foreach (string c in _identifiers)
            {
                ++i;
                if (c == id)
                {
                    _identifiers.Remove(c);
                    _identifiers.Insert(i, id.ToLower());
                    break;
                }
            }
            _identifiers.Insert(i, id.ToLower());
            i = 0;
        }
        public void PrintIdents()
        {
            foreach (string c in _identifiers)
            {
                    Console.Write(c + " ");
            };
        }
    }
}
