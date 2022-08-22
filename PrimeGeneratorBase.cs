internal abstract class PrimeGeneratorBase // TypeDefIndex: 87
{	// Properties
	public virtual ConfidenceFactor Confidence { get; }
	public virtual PrimalityTest PrimalityTest { get; }
	public virtual int TrialDivisionBounds { get; }

	// Methods

	// RVA: 0x531A90 Offset: 0x530090 VA: 0x180531A90 Slot: 4
	public virtual ConfidenceFactor get_Confidence() { }

	// RVA: 0x1648810 Offset: 0x1646E10 VA: 0x181648810 Slot: 5
	public virtual PrimalityTest get_PrimalityTest() { }

	// RVA: 0x1648870 Offset: 0x1646E70 VA: 0x181648870 Slot: 6
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

	// RVA: 0x1AC1E50 Offset: 0x1AC0450 VA: 0x181AC1E50 Slot: 5
	public virtual PrimalityTest get_PrimalityTest() { }

	// RVA: 0x1648870 Offset: 0x1646E70 VA: 0x181648870 Slot: 6
	public virtual int get_TrialDivisionBounds() { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract BigInteger GenerateNewPrime(int bits);

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

}

