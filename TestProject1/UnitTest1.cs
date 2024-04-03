using лаба10;
using лаба_9_2;
namespace TestProject1

{

    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void Constructor_WithNameAndNumber_SetsNameAndNumber()
        {
            // Arrange
            string name = "TestName";
            int number = 5;

            // Act
            var instrument = new MusicalInstrument(name, number);

            // Assert
            Assert.AreEqual(name, instrument.Name);
            Assert.AreEqual(number, instrument.num.number);
        }

        [TestMethod]
        public void Init_WithInputName_SetsName()
        {
            // Arrange
            var instrument = new MusicalInstrument();
            string expectedName = "TestName";

            // Act
            using (System.IO.StringReader sr = new System.IO.StringReader(expectedName + "\n"))
            {
                System.Console.SetIn(sr);
                instrument.Init();
            }

            // Assert
            Assert.AreEqual(expectedName, instrument.Name);
        }

       

        [TestMethod]
        public void Equals_TwoInstrumentsWithSameName_ReturnsTrue()
        {
            // Arrange
            string name = "TestName";
            var instrument1 = new MusicalInstrument(name, 1);
            var instrument2 = new MusicalInstrument(name, 2);

            // Act
            bool result = instrument1.Equals(instrument2);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Equals_TwoInstrumentsWithDifferentName_ReturnsFalse()
        {
            // Arrange
            var instrument1 = new MusicalInstrument("Name1", 1);
            var instrument2 = new MusicalInstrument("Name2", 2);

            // Act
            bool result = instrument1.Equals(instrument2);

            // Assert
            Assert.IsFalse(result);
        }
        

        

        [TestMethod]
        public void Equals_TwoGuitarsWithSameNumberOfStringsAndName_ReturnsTrue()
        {
            // Arrange
            int numberOfStrings = 6;
            string name = "TestName";
            int num = 1;
            var guitar1 = new Guitar(numberOfStrings, name, num);
            var guitar2 = new Guitar(numberOfStrings, name, num);

            // Act
            bool result = guitar1.Equals(guitar2);

            // Assert
            Assert.IsTrue(result);
        }

        

        [TestMethod]
        public void Equals_TwoGuitarsWithSameNumberOfStringsAndDifferentName_ReturnsFalse()
        {
            // Arrange
            int numberOfStrings = 6;
            int num = 1;
            var guitar1 = new Guitar(numberOfStrings, "Name1", num);
            var guitar2 = new Guitar(numberOfStrings, "Name2", num);

            // Act
            bool result = guitar1.Equals(guitar2);

            // Assert
            Assert.IsFalse(result);
        }
        
        

        

        [TestMethod]
        public void ShallowCopy_ReturnsNewInstanceOfGuitar()
        {
            // Arrange
            var originalGuitar = new Guitar(6, "Original", 1);

            // Act
            var copiedGuitar = (Guitar)originalGuitar.ShallowCopy();

            // Assert
            Assert.AreNotSame(originalGuitar, copiedGuitar);
            Assert.AreEqual(originalGuitar.Name, copiedGuitar.Name);
            Assert.AreEqual(originalGuitar.num.number, copiedGuitar.num.number);
            Assert.AreEqual(originalGuitar.NumberOfStrings, copiedGuitar.NumberOfStrings);
        }

       
        [TestMethod]
        public void Constructor_WithPowerSupplyAndNumberOfStrings_SetsPowerSupplyAndNumberOfStrings()
        {
            // Arrange
            string powerSupply = "USB";
            string name = "TestName";
            int numberOfStrings = 6;
            int num = 1;

            // Act
            var electricGuitar = new ElectricGuitar(powerSupply, name, numberOfStrings, num);

            // Assert
            Assert.AreEqual(powerSupply, electricGuitar.PowerSupply);
            Assert.AreEqual(numberOfStrings, electricGuitar.NumberOfStrings);
        }

        

        [TestMethod]
        public void Equals_TwoElectricGuitarsWithSamePowerSupplyAndName_ReturnsTrue()
        {
            // Arrange
            string powerSupply = "USB";
            string name = "TestName";
            int num = 1;
            var electricGuitar1 = new ElectricGuitar(powerSupply, name, 6, num);
            var electricGuitar2 = new ElectricGuitar(powerSupply, name, 12, num);

            // Act
            bool result = electricGuitar1.Equals(electricGuitar2);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Equals_TwoElectricGuitarsWithDifferentPowerSupplyAndSameName_ReturnsFalse()
        {
            // Arrange
            string name = "TestName";
            int num = 1;
            var electricGuitar1 = new ElectricGuitar("USB", name, 6, num);
            var electricGuitar2 = new ElectricGuitar("���������", name, 6, num);

            // Act
            bool result = electricGuitar1.Equals(electricGuitar2);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Equals_TwoElectricGuitarsWithSamePowerSupplyAndDifferentName_ReturnsFalse()
        {
            // Arrange
            string powerSupply = "USB";
            int num = 1;
            var electricGuitar1 = new ElectricGuitar(powerSupply, "Name1", 6, num);
            var electricGuitar2 = new ElectricGuitar(powerSupply, "Name2", 6, num);

            // Act
            bool result = electricGuitar1.Equals(electricGuitar2);

            // Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void Constructor_WithNumberOfKeysAndLayout_SetsNumberOfKeysAndLayout()
        {
            // Arrange
            int numberOfKeys = 88;
            string name = "TestName";
            string layout = "��������";
            int num = 1;

            // Act
            var piano = new Piano(numberOfKeys, name, layout, num);

            // Assert
            Assert.AreEqual(numberOfKeys, piano.NumberOfKeys);
            Assert.AreEqual(layout, piano.KeyboardLayout);
        }

        

        [TestMethod]
        public void Equals_TwoPianosWithSameNumberOfKeysLayoutAndName_ReturnsTrue()
        {
            // Arrange
            int numberOfKeys = 88;
            string name = "TestName";
            string layout = "��������";
            int num = 1;
            var piano1 = new Piano(numberOfKeys, name, layout, num);
            var piano2 = new Piano(numberOfKeys, name, layout, num);

            // Act
            bool result = piano1.Equals(piano2);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Equals_TwoPianosWithDifferentNumberOfKeysAndSameLayoutAndName_ReturnsFalse()
        {
            // Arrange
            string name = "TestName";
            string layout = "��������";
            int num = 1;
            var piano1 = new Piano(88, name, layout, num);
            var piano2 = new Piano(76, name, layout, num);

            // Act
            bool result = piano1.Equals(piano2);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Equals_TwoPianosWithSameNumberOfKeysAndDifferentLayoutAndName_ReturnsFalse()
        {
            // Arrange
            int numberOfKeys = 88;
            string name = "TestName";
            int num = 1;
            var piano1 = new Piano(numberOfKeys, name, "��������", num);
            var piano2 = new Piano(numberOfKeys, name, "��������", num);

            // Act
            bool result = piano1.Equals(piano2);

            // Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void Constructor_WithNameAndNumber_SetsNameAndNumber1()
        {
            // Arrange
            string name = "TestName";
            int number = 1;

            // Act
            var musicalInstrument = new MusicalInstrument(name, number);

            // Assert
            Assert.AreEqual(name, musicalInstrument.Name);
            Assert.AreEqual(number, musicalInstrument.num.number);
        }

        
        

        [TestMethod]
        public void Equals_TwoMusicalInstrumentsWithSameName_ReturnsTrue()
        {
            // Arrange
            string name = "TestName";
            var musicalInstrument1 = new MusicalInstrument(name, 1);
            var musicalInstrument2 = new MusicalInstrument(name, 2);

            // Act
            bool result = musicalInstrument1.Equals(musicalInstrument2);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Equals_TwoMusicalInstrumentsWithDifferentName_ReturnsFalse()
        {
            // Arrange
            var musicalInstrument1 = new MusicalInstrument("Name1", 1);
            var musicalInstrument2 = new MusicalInstrument("Name2", 2);

            // Act
            bool result = musicalInstrument1.Equals(musicalInstrument2);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Init_SetsNameFromUserInput()
        {
            // Arrange
            var musicalInstrument = new MusicalInstrument();
            string userInput = "UserInput";

            // Act
            using (System.IO.StringReader sr = new System.IO.StringReader(userInput + "\n"))
            {
                System.Console.SetIn(sr);
                musicalInstrument.Init();
            }

            // Assert
            Assert.AreEqual(userInput, musicalInstrument.Name);
        }

        [TestMethod]
        public void RandomInit_SetsNameFromRandomNames()
        {
            // Arrange
            var musicalInstrument = new MusicalInstrument();

            // Act
            musicalInstrument.RandomInit();

            // Assert
            Assert.IsFalse(string.IsNullOrEmpty(musicalInstrument.Name));
        }

        [TestMethod]
        public void ShallowCopy_ReturnsNewInstanceOfMusicalInstrument()
        {
            // Arrange
            var originalMusicalInstrument = new MusicalInstrument("OriginalName", 1);

            // Act
            var copiedMusicalInstrument = (MusicalInstrument)originalMusicalInstrument.ShallowCopy();

            // Assert
            Assert.AreNotSame(originalMusicalInstrument, copiedMusicalInstrument);
            Assert.AreEqual(originalMusicalInstrument.Name, copiedMusicalInstrument.Name);
            Assert.AreEqual(originalMusicalInstrument.num.number, copiedMusicalInstrument.num.number);
        }

        [TestMethod]
        public void CompareTo_TwoMusicalInstrumentsWithDifferentNames_ReturnsCorrectComparison()
        {
            // Arrange
            var musicalInstrument1 = new MusicalInstrument("Name1", 1);
            var musicalInstrument2 = new MusicalInstrument("Name2", 2);

            // Act
            int result = musicalInstrument1.CompareTo(musicalInstrument2);

            // Assert
            Assert.AreEqual(-1, result); // musicalInstrument1 is less than musicalInstrument2
        }

        [TestMethod]
        public void Clone_ReturnsNewInstanceOfMusicalInstrumentWithSameProperties()
        {
            // Arrange
            var originalMusicalInstrument = new MusicalInstrument("OriginalName", 1);

            // Act
            var clonedMusicalInstrument = (MusicalInstrument)originalMusicalInstrument.Clone();

            // Assert
            Assert.AreNotSame(originalMusicalInstrument, clonedMusicalInstrument);
            Assert.AreEqual(originalMusicalInstrument.Name, clonedMusicalInstrument.Name);
            Assert.AreEqual(originalMusicalInstrument.num.number, clonedMusicalInstrument.num.number);
        }
        [TestMethod]
        public void Constructor_WithPowerSupplyAndNumberOfStrings_SetsPowerSupplyAndNumberOfStrings1()
        {
            // Arrange
            string powerSupply = "USB";
            string name = "TestName";
            int numberOfStrings = 6;
            int num = 1;

            // Act
            var electricGuitar = new ElectricGuitar(powerSupply, name, numberOfStrings, num);

            // Assert
            Assert.AreEqual(powerSupply, electricGuitar.PowerSupply);
            Assert.AreEqual(numberOfStrings, electricGuitar.NumberOfStrings);
        }

        

        [TestMethod]
        public void Equals_TwoElectricGuitarsWithSamePowerSupplyAndName_ReturnsTrue2()
        {
            // Arrange
            string powerSupply = "USB";
            string name = "TestName";
            int num = 1;
            var electricGuitar1 = new ElectricGuitar(powerSupply, name, 6, num);
            var electricGuitar2 = new ElectricGuitar(powerSupply, name, 12, num);

            // Act
            bool result = electricGuitar1.Equals(electricGuitar2);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Equals_TwoElectricGuitarsWithDifferentPowerSupplyAndSameName_ReturnsFalse1()
        {
            // Arrange
            string name = "TestName";
            int num = 1;
            var electricGuitar1 = new ElectricGuitar("USB", name, 6, num);
            var electricGuitar2 = new ElectricGuitar("���������", name, 6, num);

            // Act
            bool result = electricGuitar1.Equals(electricGuitar2);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Equals_TwoElectricGuitarsWithSamePowerSupplyAndDifferentName_ReturnsFalse1()
        {
            // Arrange
            string powerSupply = "USB";
            int num = 1;
            var electricGuitar1 = new ElectricGuitar(powerSupply, "Name1", 6, num);
            var electricGuitar2 = new ElectricGuitar(powerSupply, "Name2", 6, num);

            // Act
            bool result = electricGuitar1.Equals(electricGuitar2);

            // Assert
            Assert.IsFalse(result);
        }

        

        [TestMethod]
        public void RandomInit_SetsPowerSupplyFromRandomPowerSupplies()
        {
            // Arrange
            var electricGuitar = new ElectricGuitar();

            // Act
            electricGuitar.RandomInit();

            // Assert
            Assert.IsFalse(string.IsNullOrEmpty(electricGuitar.PowerSupply));
        }

        [TestMethod]
        public void ShallowCopy_ReturnsNewInstanceOfElectricGuitar()
        {
            // Arrange
            var originalElectricGuitar = new ElectricGuitar("USB", "OriginalName", 6, 1);

            // Act
            var copiedElectricGuitar = (ElectricGuitar)originalElectricGuitar.ShallowCopy();

            // Assert
            Assert.AreNotSame(originalElectricGuitar, copiedElectricGuitar);
            Assert.AreEqual(originalElectricGuitar.PowerSupply, copiedElectricGuitar.PowerSupply);
            Assert.AreEqual(originalElectricGuitar.Name, copiedElectricGuitar.Name);
            Assert.AreEqual(originalElectricGuitar.NumberOfStrings, copiedElectricGuitar.NumberOfStrings);
        }
        [TestMethod]
        public void Constructor_WithNumberOfKeysNameAndLayout_SetsNumberOfKeysNameAndLayout()
        {
            // Arrange
            string name = "TestName";
            string layout = "��������";
            int numberOfKeys = 88;
            int num = 1;

            // Act
            var piano = new Piano(numberOfKeys, name, layout, num);

            // Assert
            Assert.AreEqual(numberOfKeys, piano.NumberOfKeys);
            Assert.AreEqual(name, piano.Name);
            Assert.AreEqual(layout, piano.KeyboardLayout);
        }

        

        [TestMethod]
        public void Equals_TwoPianosWithSameNumberOfKeysNameAndLayout_ReturnsTrue()
        {
            // Arrange
            string name = "TestName";
            string layout = "��������";
            int num = 1;
            var piano1 = new Piano(88, name, layout, num);
            var piano2 = new Piano(88, name, layout, num);

            // Act
            bool result = piano1.Equals(piano2);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Equals_TwoPianosWithDifferentNumberOfKeysAndSameNameAndLayout_ReturnsFalse()
        {
            // Arrange
            string name = "TestName";
            string layout = "��������";
            int num = 1;
            var piano1 = new Piano(88, name, layout, num);
            var piano2 = new Piano(76, name, layout, num);

            // Act
            bool result = piano1.Equals(piano2);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Equals_TwoPianosWithSameNumberOfKeysAndDifferentNameAndLayout_ReturnsFalse()
        {
            // Arrange
            int num = 1;
            var piano1 = new Piano(88, "Name1", "��������", num);
            var piano2 = new Piano(88, "Name2", "��������", num);

            // Act
            bool result = piano1.Equals(piano2);

            // Assert
            Assert.IsFalse(result);
        }

        

        [TestMethod]
        public void RandomInit_SetsKeyboardLayoutAndNumberOfKeysFromRandomValues()
        {
            // Arrange
            var piano = new Piano();

            // Act
            piano.RandomInit();

            // Assert
            Assert.IsFalse(string.IsNullOrEmpty(piano.KeyboardLayout));
            Assert.IsTrue(piano.NumberOfKeys >= 1 && piano.NumberOfKeys <= 88);
        }

        [TestMethod]
        public void ShallowCopy_ReturnsNewInstanceOfPiano()
        {
            // Arrange
            var originalPiano = new Piano(88, "OriginalName", "��������", 1);

            // Act
            var copiedPiano = (Piano)originalPiano.ShallowCopy();

            // Assert
            Assert.AreNotSame(originalPiano, copiedPiano);
            Assert.AreEqual(originalPiano.Name, copiedPiano.Name);
            Assert.AreEqual(originalPiano.KeyboardLayout, copiedPiano.KeyboardLayout);
            Assert.AreEqual(originalPiano.NumberOfKeys, copiedPiano.NumberOfKeys);
        }
    }
}
