internal class ISteamInput : SteamInterface // TypeDefIndex: 5120
{

	internal void .ctor(bool IsGameServer) { }

	internal static extern IntPtr SteamAPI_SteamInput_v006() { }

	public override IntPtr GetUserInterfacePointer() { }

}

