namespace TareaTestValidacionContraseña;

public class Contraseña
{
	public void InsertarContraseaña()
	{
		VerificarQueNoEsteVacio("David123");
		VerificarQueNoTengaCaracteresEspeciales("David123");
		VerificarQueTengaPorLoMenosUnaMayuscula("David123");
		VerificarQueTengaPorLoMenosUnaMinuscula("David123");
		VerificarQueLaLongitudSeaPorLoMenosCincoDigitos("David123");
		VerificarQueTengaPorLoMenosUnDigitoNumerico("David123");
	}

	public bool VerificarQueNoEsteVacio(string password)
	{
		if (String.IsNullOrEmpty(password))
			return true;

		return false;
	}
	public bool VerificarQueNoTengaCaracteresEspeciales(string password)
	{
		bool caracterEspecial = false;

		foreach (char caracter in password)
		{
			if (char.IsSymbol(caracter) || char.IsPunctuation(caracter))
				caracterEspecial = true;
		}

		return caracterEspecial == false;
	}

	public bool VerificarQueLaLongitudSeaPorLoMenosCincoDigitos(string password)
	{
		if(password.Length >= 5)
			return true;

		return false;
	}

	public bool VerificarQueTengaPorLoMenosUnaMayuscula(string password)
	{
		bool mayuscula = false;

		foreach (char caracter in password)
		{
			if (char.IsUpper(caracter))
				mayuscula = true;
		}

		return mayuscula;
	}

	public bool VerificarQueTengaPorLoMenosUnaMinuscula(string password)
	{
		bool minuscula = false;

		foreach (char caracter in password)
		{
			if (char.IsLower(caracter))
				minuscula = true;
		}

		return minuscula;
	}

	public bool VerificarQueTengaPorLoMenosUnDigitoNumerico(string password)
	{
		bool numero = false;

		foreach (char caracter in password)
		{
			if (char.IsDigit(caracter))
				numero = true;
		}
		return numero;
	}
}
