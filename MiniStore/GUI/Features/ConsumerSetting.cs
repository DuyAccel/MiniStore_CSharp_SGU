using MiniStore.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniStore.GUI.Features
{
    public class ConsumerSetting
    {
        private static MyDialog dialog;
        public static void Show()
        {
            ConsumerItem consumer = new ConsumerItem();
            dialog = new MyDialog(consumer);
            consumer.parent = dialog;
            dialog.ShowDialog();
        }
        public static void Show(ConsumerDTO consumerDTO)
        {
            ConsumerItem consumer = new ConsumerItem(consumerDTO);
            dialog = new MyDialog(consumer);
            consumer.parent = dialog;
            dialog.ShowDialog();
        }
    }
}
