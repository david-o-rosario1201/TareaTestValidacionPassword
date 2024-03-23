using TareaTestValidacionContraseña;

namespace TestProjectValidacionContraseña
{
	[TestClass]
	public class TestValidacionContraseña
	{
		[TestMethod]
		public void Should_Verify_If_The_Password_Is_Empty_Or_Null()
		{
			//Arrange
			var cut = new Contraseña();

			//Act
			string password = "";
			bool expect = false;

			var result = cut.VerificarQueNoEsteVacio(password);

			//Assert
			Assert.AreEqual(expect, result);
		}

		[TestMethod]
		public void Should_Verify_If_The_Password_Has_Special_Characters()
		{
			//Arrange
			var cut = new Contraseña();

			//Act
			string password = "David1#23";
			bool expect = true;

			var result = cut.VerificarQueNoTengaCaracteresEspeciales(password);

			//Assert
			Assert.AreEqual(expect, result);
		}

		[TestMethod]
		public void Should_Verify_If_The_Password_Has_At_Least_Five_Digits()
		{
			//Arrange
			var cut = new Contraseña();

			//Act
			string password = "Da123";
			bool expect = true;

			var result = cut.VerificarQueLaLongitudSeaPorLoMenosCincoDigitos(password);

			//Assert
			Assert.AreEqual(expect, result);
		}

		[TestMethod]
		public void Should_Verify_If_The_Password_Has_At_Least_One_Upper_Digit()
		{
			//Arrange
			var cut = new Contraseña();

			//Act
			string password = "david123";
			bool expect = true;

			var result = cut.VerificarQueTengaPorLoMenosUnaMayuscula(password);

			//Assert
			Assert.AreEqual(expect, result);
		}

		[TestMethod]
		public void Should_Verify_If_The_Password_Has_At_Least_One_Lower_Digit()
		{
			//Arrange
			var cut = new Contraseña();

			//Act
			string password = "David123";
			bool expect = true;

			var result = cut.VerificarQueTengaPorLoMenosUnaMinuscula(password);

			//Assert
			Assert.AreEqual(expect, result);
		}

		[TestMethod]
		public void Should_Verify_If_The_Password_Has_At_Least_One_Numeric_Character()
		{
			//Arrange
			var cut = new Contraseña();

			//Act
			string password = "David123";
			bool expect = true;

			var result = cut.VerificarQueTengaPorLoMenosUnDigitoNumerico(password);

			//Assert
			Assert.AreEqual(expect, result);
		}
	}
}