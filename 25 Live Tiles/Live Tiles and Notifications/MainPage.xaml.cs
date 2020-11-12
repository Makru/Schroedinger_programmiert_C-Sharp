using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Data.Xml.Dom;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Notifications;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Live_Tiles_and_Notifications {
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page {
        public MainPage() {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            var templateContent = ToastNotificationManager.GetTemplateContent(ToastTemplateType.ToastImageAndText02);
            templateContent.GetElementsByTagName("text")[0].InnerText = "Ich bin der Meister";
            templateContent.GetElementsByTagName("text")[1].InnerText = "Über alle Arten von Benachrichtigungen";
            templateContent.GetElementsByTagName("image")[0].Attributes.First(n => n.NodeName == "src").InnerText = "schroedinger.png";
            ToastNotification notification = new ToastNotification(templateContent);
            notification.ExpirationTime = DateTimeOffset.Now.AddSeconds(5);
            ToastNotificationManager.CreateToastNotifier().Show(notification);

            // Show notification delayed
            ToastNotificationManager.CreateToastNotifier().AddToSchedule(
                new ScheduledToastNotification(templateContent, DateTimeOffset.Now.AddMinutes(1)));

        }

        private void Button_Click1(object sender, RoutedEventArgs e) {
            string content = @"<toast launch=""thisIsMyApp"">
                        <visual>
                            <binding template=""ToastGeneric"">
                                <text>Das ist ein Beispieltext</text>
                                <text>Und noch viel mehr davon</text>
                                <image placement=""inline"" src=""Okay.jpg"" />
                            </binding>
                        </visual>
                        <actions>
                            <action content=""Okay"" arguments=""check"" imageUri=""okay.jpg"" />
                            <action content=""Nein"" arguments=""cancel"" />
                        </actions>
                        <audio src=""ms-winsoundevent:Notification.Reminder"" />
                    </toast>";

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(content);

            ToastNotification notification = new ToastNotification(doc);
            notification.Activated += Notification_Activated;
            ToastNotificationManager.CreateToastNotifier().Show(notification);

        }

        private void Notification_Activated(ToastNotification sender, object args) {
            var arguments = args as ToastActivatedEventArgs;
            string buttonId = arguments.Arguments;
            switch (buttonId) {
                case "check":
                    break;
                case "cancel":
                    break;
                default:
                    break;
            }
        }

        private void Button_Click2(object sender, RoutedEventArgs e) {
            string content = @"<toast launch=""thisIsMyApp"" activationType=""foreground"">
                                    <visual>
                                        <binding template=""ToastGeneric"">
                                            <text>Das ist ein Beispieltext</text>
                                            <text>Und noch viel mehr davon</text>
                                            <image placement=""AppLogoOverride"" src=""okay.jpg"" />
                                        </binding>
                                    </visual>
                                    <actions>
                                        <input id=""message"" type=""text"" placeHolderContent=""Hier reintippen"" />
                                        <action content=""Okay"" arguments=""check"" imageUri=""check.png"" />
                                        <action content=""Nein"" arguments=""cancel"" />
                                    </actions>
                                    <audio src=""ms-winsoundevent:Notification.Mail"" />
                                </toast>";

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(content);

            ToastNotification notification = new ToastNotification(doc);
            notification.Activated += Notification_Activated;
            ToastNotificationManager.CreateToastNotifier().Show(notification);

        }

        private void Button_Click3(object sender, RoutedEventArgs e) {
            string content = @"<toast launch=""thisIsMyApp"">
                                    <visual>
                                        <binding template=""ToastGeneric"">
                                            <text>Das ist ein Beispieltext</text>
                                            <text>Und noch viel mehr davon</text>
                                            <image placement=""inline"" src=""schroedinger.png"" />
                                        </binding>
                                    </visual>
                                    <actions>
                                        <input id=""message"" type=""selection"" defaultInput=""2"">
                                            <selection id=""1"" content=""Am Morgen"" />
                                            <selection id=""2"" content=""Zu Mittag"" />
                                            <selection id=""3"" content=""Am Abend"" />
                                        </input>
                                        <action content=""Okay"" arguments=""check"" imageUri=""check.png"" />
                                        <action content=""Nein"" arguments=""cancel"" />
                                    </actions>
                                    <audio src=""ms-winsoundevent:Notification.Default"" />
                                </toast>";

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(content);

            ToastNotification notification = new ToastNotification(doc);
            notification.Activated += Notification_Activated;
            ToastNotificationManager.CreateToastNotifier().Show(notification);

        }


        private void Aufgabe(object sender, RoutedEventArgs e) {
            App.ShowNotification(DateTimeOffset.Now);

            //string content = @"<toast launch=""thisIsMyApp"">
            //                        <visual>
            //                            <binding template=""ToastGeneric"">
            //                                <text>Ich komme wieder!</text>
            //                                <text>Wähle aus wann</text>
            //                                <image placement=""AppLogoOverride"" src=""schroedinger.png"" />
            //                            </binding>
            //                        </visual>
            //                        <actions>
            //                            <input id=""offset"" type=""text"" placeHolderContent=""Nochmal erinnern"" />
            //                            <input id=""unit"" type=""selection"" defaultInput=""2"">
            //                                <selection id=""1"" content=""Sekunden"" />
            //                                <selection id=""2"" content=""Minuten"" />
            //                                <selection id=""3"" content=""Stunden"" />
            //                            </input>
            //                            <action content=""Nochmal erinnern"" arguments=""check"" />
            //                            <action content=""Sei ruhig"" arguments=""cancel"" />
            //                        </actions>
            //                        <audio src=""ms-winsoundevent:Notification.Default"" />
            //                    </toast>";

            //XmlDocument doc = new XmlDocument();
            //doc.LoadXml(content);

            //ToastNotification notification = new ToastNotification(doc);
            //ToastNotificationManager.CreateToastNotifier().Show(notification);

        }
    }
}
