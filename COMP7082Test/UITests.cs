using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestStack.White.UIItems.WindowItems;
using TestStack.White.UIItems;
using TestStack.White;

namespace COMP7082Test
{
    [TestClass]
    public class UITests
    {
        private Application application;
        private Window window;

        [TestInitialize]
        public void Setup ()
        {
            if (File.Exists("gamehistory.bin"))
            {
                File.Delete("gamehistory.bin");
            }

            application = Application.Launch(Directory.GetCurrentDirectory() + "/../../../COMP7082/bin/debug/COMP7082.exe");
            window = application.GetWindow("Game History");
        }

        [TestCleanup]
        public void Teardown ()
        {
            window.Close();
            application.Close();

            application = null;
            window = null;
        }

        [TestMethod]
        public void AddTest ()
        {
            ListView listView = window.Get<ListView>("historyList");

            Assert.AreEqual(listView.Items.Count, 0);

            AddItem();

            Assert.AreEqual(listView.Items.Count, 1);

            // unfortunately only grabs the key, still test it
            Assert.AreEqual(listView.Items[0], "Mario");
        }

        [TestMethod]
        public void RemoveTest ()
        {
            AddItem();

            ListView listView = window.Get<ListView>("historyList");

            Assert.AreEqual(listView.Items.Count, 1);

            listView.Select(0);
            window.Get<Button>("removeButton").Click();

            Assert.AreEqual(listView.Items.Count, 0);
        }

        [TestMethod]
        public void EditTest ()
        {
            AddItem();

            ListView listView = window.Get<ListView>("historyList");

            Assert.AreEqual(listView.Items[0], "Mario");

            listView.Select(0);
            window.Get<Button>("editButton").Click();

            Window editDialog = window.ModalWindow("Edit");

            editDialog.Get<TextBox>("characterBox").Text = "Luigi";
            editDialog.Get<Button>("saveButton").Click();

            Assert.AreEqual(listView.Items[0], "Luigi");
        }


        // important for all tests, assumes test is currently on the history list
        private void AddItem ()
        {
            window.Get<Button>("addButton").Click();

            Window addDialog = window.ModalWindow("Add");

            addDialog.Get<TextBox>("characterBox").Text = "Mario";
            addDialog.Get<TextBox>("opponentBox").Text = "Luigi";
            addDialog.Get<TextBox>("stageBox").Text = "Battlefield";
            addDialog.Get<RadioButton>("winRadio").Click();
            addDialog.Get<Button>("addButton").Click();
        }
    }
}
