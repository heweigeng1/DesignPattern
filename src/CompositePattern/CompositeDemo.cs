using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePattern
{
    public class CompositeDemo
    {
        public void Use()
        {
            var messagebox = new MessageBox();
            messagebox.Name = "消息框";
            messagebox.Position = "108,100";
            var btn = new Button();
            btn.Name = "同意";
            btn.Position = "10,20";
            messagebox.Add(btn);
            var closeBtn = new Button();
            closeBtn.Name = "取消";
            closeBtn.Position = "5,20";
            messagebox.Add(closeBtn);
            var lable = new Lable();
            lable.Name = "我是消息!";
            lable.Position = "15,10";
            messagebox.Add(lable);

            Show(messagebox);
        }

        public void Show(Control control)
        {
            control.Draw();
        }
    }
}
