using System;
using System.Collections.Generic;

namespace TodoApplication
{
    public class ListModel<TItem>
    {
        public List<TItem> Items { get; }
        public int Limit;

        Dictionary<TItem, int> dictLimit = new Dictionary<TItem, int>();
        LinkedList<TItem> dictKeys = new LinkedList<TItem>();

        private LinkedList<string> logs = new LinkedList<string>();

        public ListModel(int limit)
        {
            Items = new List<TItem>();
            Limit = limit;
        }

        public void AddItem(TItem item)
        {
            logs.AddFirst("AddItem");
            Items.Add(item);
            if (logs.Count > Limit)
            {
                logs.RemoveLast();
            }

        }

        public void RemoveItem(int index)
        {
            logs.AddFirst("RemoveItem");
            if (logs.Count > Limit)
            {
                logs.RemoveLast();
            }
            dictLimit.Add(Items[index], index);
            dictKeys.AddFirst(Items[index]);

            Items.RemoveAt(index);
        }

        public bool CanUndo()
        {
            if (logs.Count != 0)
                return true;
            else
                return false;
        }

        public void Undo()
        {

            switch (logs.First.Value)
            {
                case "AddItem":
                    {
                        Items.RemoveAt(Items.Count - 1);
                        logs.RemoveFirst();
                        break;
                    }
                case "RemoveItem":
                    {
                        Items.Insert(dictLimit[dictKeys.First.Value], dictKeys.First.Value);
                        dictLimit.Remove(dictKeys.First.Value);
                        dictKeys.RemoveFirst();
                        logs.RemoveFirst();
                        break;
                    }
            }


        }
    }
}
