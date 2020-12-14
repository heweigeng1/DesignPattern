using System;
using System.Collections.Generic;

namespace CompositePattern
{
    public abstract class Control
    {
        public string Position { get; set; }

        public string Name { get; set; }

        public virtual void Draw()
        {
            Console.WriteLine($"{Name}-{Position}");
            if (ChildControl!=null&&ChildControl.Count>0)
            {
                foreach (var item in ChildControl)
                {
                    item.Draw();
                }
            }
        }

        private List<Control> ChildControl { get; set; } = new List<Control>();

        public void Add(Control control)
        {
            ChildControl.Add(control);
        }

        public void Remove(Control control)
        {
            ChildControl.Remove(control);
        }
    }
}
