using System;
using System.Windows.Forms;

namespace BTI_MySqlServer
{
    //public interface IMessage
    //{
    //    DialogResult ShowInformation(string Name, string Text);
    //    DialogResult ShowWarning(string Name, string Text);
    //    DialogResult ShowError(string Name, string Text);
    //    DialogResult ShowQuestion(string Name, string Text);
    //}

    static class Message //: IMessage не испольую что бы не содавать экемпляры
    {
        public static DialogResult ShowInformation(string Name, string Text)
        {
            return MessageBox.Show(Text , Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static DialogResult ShowWarningRetry(string Name, string Text)
        {
            return MessageBox.Show(Text, Name, MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
        }

        public static DialogResult ShowError(string Name, string Text)
        {
            return MessageBox.Show("Возникла непредвиденная ошибка. Приложение будет закрыто. Обратитесь за помощью к разработчику данного ПО, подробно описав Ваши действия. Информация о необработанном исключении:\n" 
                + Text, Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static DialogResult ShowFatalError(Exception ex)
        {
            return MessageBox.Show(
                string.Format("Возникла непредвиденная ошибка. Приложение будет закрыто. Обратитесь за помощью к разработчику данного ПО, подробно описав Ваши действия."+
                " \nИнформация о источнике исключения:\n{0} \nИнформация о необработанном исключении:\n{1} \nСтек вызовов:\n{2}", ex.Source, ex.Message, ex.StackTrace), 
            "Проиошла фатальная ошибка))", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static DialogResult ShowQuestion(string Name, string Text)
        {
            return MessageBox.Show(Text, Name, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}