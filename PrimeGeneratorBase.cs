internal abstract class PrimeGeneratorBase // TypeDefIndex: 87
{	// Properties
	public virtual ConfidenceFactor Confidence { get; }
	public virtual PrimalityTest PrimalityTest { get; }
	public virtual int TrialDivisionBounds { get; }

	// Methods

	// RVA: 0x531A20 Offset: 0x530020 VA: 0x180531A20 Slot: 4
	public virtual ConfidenceFactor get_Confidence() { }

	// RVA: 0x1635B30 Offset: 0x1634130 VA: 0x181635B30 Slot: 5
	public virtual PrimalityTest get_PrimalityTest() { }

	// RVA: 0x1635B90 Offset: 0x1634190 VA: 0x181635B90 Slot: 6
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

	// RVA: 0x531A20 Offset: 0x530020 VA: 0x180531A20 Slot: 4
	public virtual ConfidenceFactor get_Confidence() { }

	// RVA: 0x1AC2640 Offset: 0x1AC0C40 VA: 0x181AC2640 Slot: 5
	public virtual PrimalityTest get_PrimalityTest() { }

	// RVA: 0x1635B90 Offset: 0x1634190 VA: 0x181635B90 Slot: 6
	public virtual int get_TrialDivisionBounds() { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract BigInteger GenerateNewPrime(int bits);

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

}

