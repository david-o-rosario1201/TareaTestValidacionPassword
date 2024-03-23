namespace TareaTestValidacionContraseña;

public class VerificarContraseña
{
	public bool VerificarVacio(string password)
	{
		return String.IsNullOrEmpty(password);
	}

	public bool VerificarCarecteresEspeciales(string password, string patronCaracteresEspeciales)
	{
		return System.Text.RegularExpressions.Regex.IsMatch(password, patronCaracteresEspeciales);
	}

	public bool VerificarLongitud(string password)
	{
		return password.Length >= 5;
	}

	public bool VerificarMayusculas(string password, string patronMayusculas)
	{
		return System.Text.RegularExpressions.Regex.IsMatch(password, patronMayusculas);
	}

	public bool VerificarMinusculas(string password, string patronMinusculas)
	{
		return System.Text.RegularExpressions.Regex.IsMatch(password, patronMinusculas);
	}

	public bool VerificarDigitosNumericos(string password, string patronDigitos)
	{
		return System.Text.RegularExpressions.Regex.IsMatch(password, patronDigitos);
	}
}
