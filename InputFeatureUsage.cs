public struct InputFeatureUsage : IEquatable<InputFeatureUsage> // TypeDefIndex: 4144
{	internal string m_Name; // 0x0
	[NativeNameAttribute] // RVA: 0x95B50 Offset: 0x94F50 VA: 0x180095B50
	internal InputFeatureType m_InternalType; // 0x8

	public string name { get; }
	internal InputFeatureType internalType { get; }


	public string get_name() { }

	internal InputFeatureType get_internalType() { }

	public override bool Equals(object obj) { }

	public bool Equals(InputFeatureUsage other) { }

	public override int GetHashCode() { }

}

