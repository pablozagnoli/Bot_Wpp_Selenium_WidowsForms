using OpenQA.Selenium.Chrome;
using System;
using System.Threading;


namespace BotForms
{
    public class Chat_Monitora : Form1
    {
        #region█VARIABLESGLOBAIS
        ChromeOptions vChromeOp = new ChromeOptions();
        public ChromeDriver vCrome = new ChromeDriver(@"C:\Program Files\Google\Chrome\Application\");
        public string vUrl = "https://web.whatsapp.com/";
        public string vContato = String.Empty;
        public int vSpanCount = 0;
        public string vTagMessageChatText = string.Empty;
        int vConvertDateMessage = 0;
        bool vtryVer = true;

        #endregion
        public void Verify_Chat_Open(string vMenssagemSearch1, string vMenssagemSend1, string vMenssagemSearch2, string vMenssagemSend2, string vMenssagemSearch3, string vMenssagemSend3)
        {
            try
            {
                vCrome.Navigate().GoToUrl(vUrl);

                Thread.Sleep(8000);

                while (vtryVer)
                {
                    try
                    {
                        var vTagTextSearch = vCrome.FindElementByClassName("selectable-text");
                        vtryVer = false;
                    }
                    catch (Exception)
                    {
                        vtryVer = true;
                    }
                }
                Monitor_Message_in(vMenssagemSearch1, vMenssagemSend1, vMenssagemSearch2, vMenssagemSend2, vMenssagemSearch3, vMenssagemSend3);
            }
            catch (Exception)
            {
            }
        }
        public void Monitor_Message_in(string vMenssagemSearch1, string vMenssagemSend1, string vMenssagemSearch2, string vMenssagemSend2, string vMenssagemSearch3, string vMenssagemSend3)
        {
            try
            {
                while (true)
                {
                    var vTagsHoursMessages = vCrome.FindElementsByClassName("_15smv");

                    for (int i = 0; i < vTagsHoursMessages.Count; i++)
                    {
                        try
                        {
                            vConvertDateMessage = (Int32.Parse(vTagsHoursMessages[i].Text.ToString().Substring(0, 2))) + (Int32.Parse(vTagsHoursMessages[i].Text.ToString().Substring(3, 2)));
                        }
                        catch (Exception)
                        {
                            vConvertDateMessage = 0;
                        }
                        DateTime vDateSystem = DateTime.Now;
                        int vHourSystem = vDateSystem.Hour + vDateSystem.Minute;

                        if (vConvertDateMessage < vHourSystem && vConvertDateMessage > 0 || vConvertDateMessage == vHourSystem)
                        {
                            vTagsHoursMessages[i].Click();

                            Thread.Sleep(1000);

                            var vTagMessageChat = vCrome.FindElementsByClassName("_3ExzF");

                            if (vTagMessageChat.Count > 0)
                            {
                                vTagMessageChatText = vTagMessageChat[vTagMessageChat.Count - 1].Text;
                            }
                            else
                            {
                                vTagMessageChatText = "abc";
                            }

                            //Ia Responsavel por Responder as Mensagens
                            if (vTagMessageChatText == vMenssagemSearch1)
                            {
                                vTagsHoursMessages[i].Click();

                                Thread.Sleep(3000);

                                var vTagTextMessageSend = vCrome.FindElementsByClassName("_2_1wd");
                                vTagTextMessageSend[1].SendKeys(vMenssagemSend1);

                                Thread.Sleep(3000);

                                var vTagButtonSend = vCrome.FindElementByClassName("_1E0Oz");
                                vTagButtonSend.Click();

                                Thread.Sleep(3000);
                            }

                            if (vTagMessageChatText == vMenssagemSearch2)
                            {
                                vTagsHoursMessages[i].Click();

                                Thread.Sleep(3000);

                                var vTagTextMessageSend = vCrome.FindElementsByClassName("_2_1wd");
                                vTagTextMessageSend[1].SendKeys(vMenssagemSend2);

                                Thread.Sleep(3000);

                                var vTagButtonSend = vCrome.FindElementByClassName("_1E0Oz");
                                vTagButtonSend.Click();

                                Thread.Sleep(3000);
                            }

                            if (vTagMessageChatText == vMenssagemSearch3)
                            {
                                vTagsHoursMessages[i].Click();

                                Thread.Sleep(3000);

                                var vTagTextMessageSend = vCrome.FindElementsByClassName("_2_1wd");
                                vTagTextMessageSend[1].SendKeys(vMenssagemSend3);

                                Thread.Sleep(3000);

                                var vTagButtonSend = vCrome.FindElementByClassName("_1E0Oz");
                                vTagButtonSend.Click();

                                Thread.Sleep(3000);
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
