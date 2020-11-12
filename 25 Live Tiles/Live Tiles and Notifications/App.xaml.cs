using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel;
using Windows.ApplicationModel.Activation;
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

namespace Live_Tiles_and_Notifications {
    /// <summary>
    /// Provides application-specific behavior to supplement the default Application class.
    /// </summary>
    sealed partial class App : Application {
        /// <summary>
        /// Initializes the singleton application object.  This is the first line of authored code
        /// executed, and as such is the logical equivalent of main() or WinMain().
        /// </summary>
        public App() {
            this.InitializeComponent();
            this.Suspending += OnSuspending;

            CreateLiveTiles();
        }

        private static void CreateLiveTiles() {
            FilmInfo[] infos = new FilmInfo[] {
                new FilmInfo() {
                    Number = "42",
                    FilmInfo1 = "Per Anhalter durch die Galaxis",
                    FilmInfo2 = "dieser Film machte diese Zahl zum Nerd-Code.",
                    FilmInfo3 = "Ein Film der eine Zahl berühmt machte: Per Anhalter durch die Galaxis"
                },
                new FilmInfo() {
                    Number = "73",
                    FilmInfo1 = "Big Bang Theorie",
                    FilmInfo2 = "Sheldon Lee Cooper in Folge 73",
                    FilmInfo3 = "Sheldon Lee Cooper prägte diese Zahl in Folge 73."
                },
                new FilmInfo() {
                    Number = "21",
                    FilmInfo1 = "Die halbe Wahrheit oder volle Lüge",
                    FilmInfo2 = "Auch geprägt durch die Zahl 42 aus Per Anhalter durch die Galaxis",
                    FilmInfo3 = "Auch geprägt durch die Zahl 42 aus Per Anhalter durch die Galaxis"
                }
            };

            int num = new Random(DateTime.Now.Millisecond).Next(infos.Length);

            var updater = TileUpdateManager.CreateTileUpdaterForApplication();
            var notification = new TileNotification(TileUpdateManager.GetTemplateContent(TileTemplateType.TileSquare150x150Block));

            notification.Content.GetElementsByTagName("text")[0].InnerText = infos[num].Number;
            notification.Content.GetElementsByTagName("text")[1].InnerText = infos[num].FilmInfo1;

            var notify2 = new TileNotification(TileUpdateManager.GetTemplateContent(TileTemplateType.TileSquare310x310TextList01));
            var texts = notify2.Content.GetElementsByTagName("text");
            texts[0].InnerText = infos[0].Number;
            texts[1].InnerText = infos[0].FilmInfo1;
            texts[2].InnerText = infos[0].FilmInfo2;
            texts[3].InnerText = infos[1].Number;
            texts[4].InnerText = infos[1].FilmInfo1;
            texts[5].InnerText = infos[1].FilmInfo2;
            texts[7].InnerText = infos[2].Number;
            texts[8].InnerText = infos[2].FilmInfo1;
            texts[6].InnerText = infos[2].FilmInfo2;


            var notify3 = new TileNotification(TileUpdateManager.GetTemplateContent(TileTemplateType.TileWide310x150BlockAndText02));
            var textElements = notify3.Content.GetElementsByTagName("text");
            textElements[0].InnerText = infos[num].FilmInfo3;
            textElements[1].InnerText = infos[num].Number;
            textElements[2].InnerText = "Die Zahl";
            XmlElement element = (XmlElement)notify3.Content.GetElementsByTagName("binding")[0];
            element.SetAttribute("branding", "none");

            // Zusammenfügen der binding Tiles
            IXmlNode node = notify3.Content.ImportNode(notification.Content.GetElementsByTagName("binding")[0], true);
            notify3.Content.GetElementsByTagName("visual")[0].AppendChild(node);
            node = notify3.Content.ImportNode(notify2.Content.GetElementsByTagName("binding")[0], true);
            notify3.Content.GetElementsByTagName("visual")[0].AppendChild(node);
            notification.ExpirationTime = DateTime.Now.AddSeconds(12);
            updater.Update(notify3);

            updater.EnableNotificationQueue(true);
            // http://code.msdn.microsoft.com/windowsapps/Tile-Update-every-minute-68dbbbff
        }

        protected override void OnActivated(IActivatedEventArgs args) {
            base.OnActivated(args);

            if (args.Kind == ActivationKind.ToastNotification) {
                var toastArgs = args as ToastNotificationActivatedEventArgs;
                var arguments = toastArgs.Argument;
                if (toastArgs.UserInput.ContainsKey("message")) {
                    var input = toastArgs.UserInput["message"];
                }
                else if (toastArgs.UserInput.ContainsKey("offset")) {
                    if (arguments == "again") {
                        var offset = int.Parse(toastArgs.UserInput["offset"].ToString());
                        var unit = toastArgs.UserInput["unit"].ToString();
                        DateTimeOffset delay = DateTimeOffset.Now;
                        switch (unit) {
                            case "s":
                                delay = delay.AddSeconds(offset);
                                break;
                            case "m":
                                delay = delay.AddMinutes(offset);
                                break;
                            case "h":
                                delay = delay.AddHours(offset);
                                break;
                            default:
                                break;
                        }

                        ShowNotification(delay);
                    }
                }
            }
        }

        public static void ShowNotification(DateTimeOffset offset) {
            string content = @"<toast launch=""thisIsMyApp"">
                    <visual>
                        <binding template=""ToastGeneric"">
                            <text>Ich komme wieder!</text>
                            <text>Wähle aus wann</text>
                            <image placement=""AppLogoOverride"" src=""schroedinger.png"" />
                        </binding>
                    </visual>
                    <actions>
                        <input id=""offset"" type=""text"" placeHolderContent=""Nochmal erinnern"" />
                        <input id=""unit"" type=""selection"" defaultInput=""s"">
                            <selection id=""s"" content=""Sekunden"" />
                            <selection id=""m"" content=""Minuten"" />
                            <selection id=""h"" content=""Stunden"" />
                        </input>
                        <action content=""Nochmal erinnern"" arguments=""again"" />
                        <action content=""Sei ruhig"" arguments=""cancel"" />
                    </actions>
                    <audio src=""ms-winsoundevent:Notification.Default"" />
                </toast>";
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(content);

            if (offset <= DateTimeOffset.Now)
                ToastNotificationManager.CreateToastNotifier().Show(
                    new ToastNotification(doc));
            else
                ToastNotificationManager.CreateToastNotifier().AddToSchedule(
                    new ScheduledToastNotification(doc, offset));
        }

        /// <summary>
        /// Invoked when the application is launched normally by the end user.  Other entry points
        /// will be used such as when the application is launched to open a specific file.
        /// </summary>
        /// <param name="e">Details about the launch request and process.</param>
        protected override void OnLaunched(LaunchActivatedEventArgs e) {

#if DEBUG
            if (System.Diagnostics.Debugger.IsAttached) {
                this.DebugSettings.EnableFrameRateCounter = true;
            }
#endif

            Frame rootFrame = Window.Current.Content as Frame;

            // Do not repeat app initialization when the Window already has content,
            // just ensure that the window is active
            if (rootFrame == null) {
                // Create a Frame to act as the navigation context and navigate to the first page
                rootFrame = new Frame();

                rootFrame.NavigationFailed += OnNavigationFailed;

                if (e.PreviousExecutionState == ApplicationExecutionState.Terminated) {
                    //TODO: Load state from previously suspended application
                }

                // Place the frame in the current Window
                Window.Current.Content = rootFrame;
            }

            if (rootFrame.Content == null) {
                // When the navigation stack isn't restored navigate to the first page,
                // configuring the new page by passing required information as a navigation
                // parameter
                rootFrame.Navigate(typeof(MainPage), e.Arguments);
            }
            // Ensure the current window is active
            Window.Current.Activate();
        }

        /// <summary>
        /// Invoked when Navigation to a certain page fails
        /// </summary>
        /// <param name="sender">The Frame which failed navigation</param>
        /// <param name="e">Details about the navigation failure</param>
        void OnNavigationFailed(object sender, NavigationFailedEventArgs e) {
            throw new Exception("Failed to load Page " + e.SourcePageType.FullName);
        }

        /// <summary>
        /// Invoked when application execution is being suspended.  Application state is saved
        /// without knowing whether the application will be terminated or resumed with the contents
        /// of memory still intact.
        /// </summary>
        /// <param name="sender">The source of the suspend request.</param>
        /// <param name="e">Details about the suspend request.</param>
        private void OnSuspending(object sender, SuspendingEventArgs e) {
            var deferral = e.SuspendingOperation.GetDeferral();
            //TODO: Save application state and stop any background activity
            deferral.Complete();
        }
    }
}
