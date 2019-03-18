using SilverlightData.ViewXaml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace SilverlightData.ViewXaml
{
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();
        }
        Dictionary<EnumJudges, string> dic = new Dictionary<EnumJudges, string>();
        Dictionary<EnumEpmlees, string> dicE = new Dictionary<EnumEpmlees, string>();
        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            var user = TxbUser.Text;
            var password = TxbPassword.Password;
            if (user != "" && password != "")
            {
                if (dic.ContainsValue(user) || dicE.ContainsValue(user))
                {
                    if (password == "123")
                    {
                        MessageBox.Show("登录成功！");
                        Shar.user = user;
                        if (dic.ContainsValue(user))
                        {
                            this.Content = new JuageWindow();
                        }
                        else
                        {
                            this.Content = new EmpleeWindow();
                        }
                    }
                    else
                    {
                        MessageBox.Show("密码错误!");
                        TxbPassword.Password = "";
                    }
                }
                else
                {
                    MessageBox.Show("无该账户信息");
                    TxbUser.Text = "";
                    TxbPassword.Password = "";
                }
            }
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.TxbUser.Text = "";
            this.TxbPassword.Password = "";
        }

        private void LayoutRoot_Loaded(object sender, RoutedEventArgs e)
        {
            dic.Add(EnumJudges.CEO, "CEO");
            dic.Add(EnumJudges.Jock, "Jock");
            dic.Add(EnumJudges.张明, "张明");
            dic.Add(EnumJudges.李明, "李明");
            dic.Add(EnumJudges.杜明, "杜明");
            dicE.Add(EnumEpmlees.小明, "小明");
            dicE.Add(EnumEpmlees.杜丽, "杜丽");
            dicE.Add(EnumEpmlees.王明, "王明");
        }
    }
}
