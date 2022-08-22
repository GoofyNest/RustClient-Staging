internal abstract class PrimeGeneratorBase // TypeDefIndex: 87
{	// Properties
	public virtual ConfidenceFactor Confidence { get; }
	public virtual PrimalityTest PrimalityTest { get; }
	public virtual int TrialDivisionBounds { get; }

	// Methods

	// RVA: 0x531A90 Offset: 0x530090 VA: 0x180531A90 Slot: 4
	public virtual ConfidenceFactor get_Confidence() { }

	// RVA: 0x1648550 Offset: 0x1646B50 VA: 0x181648550 Slot: 5
	public virtual PrimalityTest get_PrimalityTest() { }

	// RVA: 0x16485B0 Offset: 0x1646BB0 VA: 0x1816485B0 Slot: 6
	public virtual int get_TrialDivisionBounds() { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract BigInteger GenerateNewPrime(int bits);

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

}

public abstract class PrimeGeneratorBase // TypeDefIndex: 1770
{	// Properties
	public virtual ConfidenceFactor Confidence { get; }
	public virtual PrimalityTest PrimalityTest { get; }
	public virtual int TrialDivisionBounds { get; }

	// Methods

	// RVA: 0x531A90 Offset: 0x530090 VA: 0x180531A90 Slot: 4
	public virtual ConfidenceFactor get_Confidence() { }

	// RVA: 0x1AC1B90 Offset: 0x1AC0190 VA: 0x181AC1B90 Slot: 5
	public virtual PrimalityTest get_PrimalityTest() { }

	// RVA: 0x16485B0 Offset: 0x1646BB0 VA: 0x1816485B0 Slot: 6
	public virtual int get_TrialDivisionBounds() { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract BigInteger GenerateNewPrime(int bits);

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

}

