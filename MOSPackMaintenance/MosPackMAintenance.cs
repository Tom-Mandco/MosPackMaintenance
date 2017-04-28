namespace MCO.Applications.MOSPackMaintenance
{
    using System;
    using System.Windows.Forms;

    static class MosPackMaintenance
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            CompositionRoot.Wire(new ApplicationModule());

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(CompositionRoot.Resolve<PackCreationScreen>());
        }
    }
}
