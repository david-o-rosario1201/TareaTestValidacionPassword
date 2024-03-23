namespace TareaTestValidacionContraseña;

public class Contraseña
{
	public void InsertarContraseaña()
	{
		string password = "";
		string patronMayusculas = @"[A-Z]{1,}";
		string patronMinusculas = @"[a-z]{1,}";
		string patronDigitos = @"[0-9]{1,}";	
		string patronCaracteresEspeciales = @"\W";

		VerificarContraseña verificarContraseña = new VerificarContraseña();

		verificarContraseña.VerificarVacio(password);
		verificarContraseña.VerificarCarecteresEspeciales(password, patronCaracteresEspeciales);
		verificarContraseña.VerificarLongitud(password);
		verificarContraseña.VerificarMayusculas(password, patronMayusculas);
		verificarContraseña.VerificarMinusculas(password, patronMinusculas);
		verificarContraseña.VerificarDigitosNumericos(password, patronDigitos);
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
