public class EOS // TypeDefIndex: 7983
{

internal class <Module>

public class EOS
	private static string productName; 
	private static string productVersion; 
	private static string productId; 
	private static string sandboxId; 
	private static string deploymentId; 
	public static PlatformInterface Interface; 
	private const float interfaceTickInterval = 0,1;
	private static float interfaceTickTimer; 
	private static StreamWriter logWriter; 


	private static void OnLogMessage(ref LogMessage logMessage) { }

	public static void Initialize(bool isServer, string clientId, string clientSecret, string logFile) { }

	public static void AddAuthExpirationCallback(OnAuthExpirationCallback callback) { }

	public static void Login(string steamLoginCredentialToken, OnLoginCallback callback) { }

	public static void CreateUser(ContinuanceToken token, OnCreateUserCallback callback) { }

	public static void Shutdown() { }

	public static void Tick() { }

	public static void Tick(float deltaTime) { }

	public void .ctor() { }

	private static void .cctor() { }

}

