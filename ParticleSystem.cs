public sealed class ParticleSystem : Component // TypeDefIndex: 4527
{
[NativeHeaderAttribute] // RVA: 0xECB30 Offset: 0xEBF30 VA: 0x1800ECB30
[NativeHeaderAttribute] // RVA: 0xECB30 Offset: 0xEBF30 VA: 0x1800ECB30
[NativeHeaderAttribute] // RVA: 0xECB30 Offset: 0xEBF30 VA: 0x1800ECB30
[NativeHeaderAttribute] // RVA: 0xECB30 Offset: 0xEBF30 VA: 0x1800ECB30
[NativeHeaderAttribute] // RVA: 0xECB30 Offset: 0xEBF30 VA: 0x1800ECB30
[RequireComponent] // RVA: 0xECB30 Offset: 0xEBF30 VA: 0x1800ECB30
[UsedByNativeCodeAttribute] // RVA: 0xECB30 Offset: 0xEBF30 VA: 0x1800ECB30
[NativeHeaderAttribute] // RVA: 0xECB30 Offset: 0xEBF30 VA: 0x1800ECB30
[NativeHeaderAttribute] // RVA: 0xECB30 Offset: 0xEBF30 VA: 0x1800ECB30
[NativeHeaderAttribute] // RVA: 0xECB30 Offset: 0xEBF30 VA: 0x1800ECB30
public sealed class ParticleSystem : Component // TypeDefIndex: 4527
	[ObsoleteAttribute] // RVA: 0xEE630 Offset: 0xEDA30 VA: 0x1800EE630
	public bool playOnAwake { get; }
	[ObsoleteAttribute] // RVA: 0xEE6A0 Offset: 0xEDAA0 VA: 0x1800EE6A0
	public float duration { get; }
	[ObsoleteAttribute] // RVA: 0xEE810 Offset: 0xEDC10 VA: 0x1800EE810
	public bool enableEmission { get; set; }
	[ObsoleteAttribute] // RVA: 0xEE940 Offset: 0xEDD40 VA: 0x1800EE940
	public float emissionRate { get; set; }
	[ObsoleteAttribute] // RVA: 0xEEA70 Offset: 0xEDE70 VA: 0x1800EEA70
	public float startSpeed { get; set; }
	[ObsoleteAttribute] // RVA: 0xEEBD0 Offset: 0xEDFD0 VA: 0x1800EEBD0
	public float startSize { get; set; }
	[ObsoleteAttribute] // RVA: 0xEED40 Offset: 0xEE140 VA: 0x1800EED40
	public float startLifetime { get; set; }
	[ObsoleteAttribute] // RVA: 0xEEF00 Offset: 0xEE300 VA: 0x1800EEF00
	public float gravityModifier { get; set; }
	public bool isPlaying { get; }
	public bool isStopped { get; }
	public int particleCount { get; }
	public bool useAutoRandomSeed { set; }
	public ParticleSystem.MainModule main { get; }
	public ParticleSystem.EmissionModule emission { get; }
	public ParticleSystem.ShapeModule shape { get; }
	public ParticleSystem.ColorOverLifetimeModule colorOverLifetime { get; }
	public ParticleSystem.CollisionModule collision { get; }


	[ObsoleteAttribute] // RVA: 0xED260 Offset: 0xEC660 VA: 0x1800ED260
	public void Emit(Vector3 position, Vector3 velocity, float size, float lifetime, Color32 color) { }

	[ObsoleteAttribute] // RVA: 0xED3A0 Offset: 0xEC7A0 VA: 0x1800ED3A0
	public void Emit(ParticleSystem.Particle particle) { }

	public bool get_playOnAwake() { }

	public float get_duration() { }

	public bool get_enableEmission() { }

	public void set_enableEmission(bool value) { }

	public float get_emissionRate() { }

	public void set_emissionRate(float value) { }

	public float get_startSpeed() { }

	public void set_startSpeed(float value) { }

	public float get_startSize() { }

	public void set_startSize(float value) { }

	public float get_startLifetime() { }

	public void set_startLifetime(float value) { }

	public float get_gravityModifier() { }

	public void set_gravityModifier(float value) { }

	[NativeNameAttribute] // RVA: 0xED420 Offset: 0xEC820 VA: 0x1800ED420
	public bool get_isPlaying() { }

	[NativeNameAttribute] // RVA: 0xED500 Offset: 0xEC900 VA: 0x1800ED500
	public bool get_isStopped() { }

	[NativeNameAttribute] // RVA: 0xED600 Offset: 0xECA00 VA: 0x1800ED600
	public int get_particleCount() { }

	[NativeNameAttribute] // RVA: 0xED6B0 Offset: 0xECAB0 VA: 0x1800ED6B0
	public void set_useAutoRandomSeed(bool value) { }

	[FreeFunctionAttribute] // RVA: 0xED910 Offset: 0xECD10 VA: 0x1800ED910
	public void Simulate(float t, bool withChildren, bool restart, bool fixedTimeStep) { }

	public void Simulate(float t, bool withChildren, bool restart) { }

	public void Simulate(float t, bool withChildren) { }

	public void Simulate(float t) { }

	[FreeFunctionAttribute] // RVA: 0xED9E0 Offset: 0xECDE0 VA: 0x1800ED9E0
	public void Play(bool withChildren) { }

	public void Play() { }

	[FreeFunctionAttribute] // RVA: 0xEDB00 Offset: 0xECF00 VA: 0x1800EDB00
	public void Pause(bool withChildren) { }

	public void Pause() { }

	[FreeFunctionAttribute] // RVA: 0xEDC10 Offset: 0xED010 VA: 0x1800EDC10
	public void Stop(bool withChildren, ParticleSystemStopBehavior stopBehavior) { }

	public void Stop(bool withChildren) { }

	public void Stop() { }

	[FreeFunctionAttribute] // RVA: 0xEDCC0 Offset: 0xED0C0 VA: 0x1800EDCC0
	public void Clear(bool withChildren) { }

	public void Clear() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void Emit(int count) { }

	[NativeNameAttribute] // RVA: 0xEDE30 Offset: 0xED230 VA: 0x1800EDE30
	private void Emit_Internal(int count) { }

	[NativeNameAttribute] // RVA: 0xEE010 Offset: 0xED410 VA: 0x1800EE010
	public void Emit(ParticleSystem.EmitParams emitParams, int count) { }

	[NativeNameAttribute] // RVA: 0xEE110 Offset: 0xED510 VA: 0x1800EE110
	private void EmitOld_Internal(ref ParticleSystem.Particle particle) { }

	internal void* GetManagedJobData() { }

	internal JobHandle GetManagedJobHandle() { }

	internal void SetManagedJobHandle(JobHandle handle) { }

	[FreeFunctionAttribute] // RVA: 0xEAAE0 Offset: 0xE9EE0 VA: 0x1800EAAE0
	internal static JobHandle ScheduleManagedJob(ref JobsUtility.JobScheduleParameters parameters, void* additionalData) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	internal static void CopyManagedJobData(void* systemPtr, out NativeParticleData particleData) { }

	public ParticleSystem.MainModule get_main() { }

	public ParticleSystem.EmissionModule get_emission() { }

	public ParticleSystem.ShapeModule get_shape() { }

	public ParticleSystem.ColorOverLifetimeModule get_colorOverLifetime() { }

	public ParticleSystem.CollisionModule get_collision() { }

	private void Emit_Injected(ref ParticleSystem.EmitParams emitParams, int count) { }

	private void GetManagedJobHandle_Injected(out JobHandle ret) { }

	private void SetManagedJobHandle_Injected(ref JobHandle handle) { }

	private static void ScheduleManagedJob_Injected(ref JobsUtility.JobScheduleParameters parameters, void* additionalData, out JobHandle ret) { }

}

public struct ParticleSystem.MainModule // TypeDefIndex: 4528
{	internal ParticleSystem m_ParticleSystem; // 0x0

	public float duration { get; }
	public ParticleSystem.MinMaxCurve startLifetime { get; set; }
	public float startLifetimeMultiplier { get; set; }
	public ParticleSystem.MinMaxCurve startSpeed { get; set; }
	public float startSpeedMultiplier { get; set; }
	[NativeNameAttribute] // RVA: 0xEF150 Offset: 0xEE550 VA: 0x1800EF150
	public ParticleSystem.MinMaxCurve startSize { get; set; }
	[NativeNameAttribute] // RVA: 0xEF260 Offset: 0xEE660 VA: 0x1800EF260
	public float startSizeMultiplier { get; set; }
	public ParticleSystem.MinMaxGradient startColor { get; set; }
	public float gravityModifierMultiplier { get; set; }
	public ParticleSystemSimulationSpace simulationSpace { set; }
	public bool playOnAwake { get; }
	public int maxParticles { get; set; }
	public ParticleSystemCullingMode cullingMode { set; }


	internal void .ctor(ParticleSystem particleSystem) { }

	public float get_duration() { }

	public ParticleSystem.MinMaxCurve get_startLifetime() { }

	public void set_startLifetime(ParticleSystem.MinMaxCurve value) { }

	public float get_startLifetimeMultiplier() { }

	public void set_startLifetimeMultiplier(float value) { }

	public ParticleSystem.MinMaxCurve get_startSpeed() { }

	public void set_startSpeed(ParticleSystem.MinMaxCurve value) { }

	public float get_startSpeedMultiplier() { }

	public void set_startSpeedMultiplier(float value) { }

	public ParticleSystem.MinMaxCurve get_startSize() { }

	public void set_startSize(ParticleSystem.MinMaxCurve value) { }

	public float get_startSizeMultiplier() { }

	public void set_startSizeMultiplier(float value) { }

	public ParticleSystem.MinMaxGradient get_startColor() { }

	public void set_startColor(ParticleSystem.MinMaxGradient value) { }

	public float get_gravityModifierMultiplier() { }

	public void set_gravityModifierMultiplier(float value) { }

	public void set_simulationSpace(ParticleSystemSimulationSpace value) { }

	public bool get_playOnAwake() { }

	public int get_maxParticles() { }

	public void set_maxParticles(int value) { }

	public void set_cullingMode(ParticleSystemCullingMode value) { }

	private static float get_duration_Injected(ref ParticleSystem.MainModule _unity_self) { }

	private static void get_startLifetime_Injected(ref ParticleSystem.MainModule _unity_self, out ParticleSystem.MinMaxCurve ret) { }

	private static void set_startLifetime_Injected(ref ParticleSystem.MainModule _unity_self, ref ParticleSystem.MinMaxCurve value) { }

	private static float get_startLifetimeMultiplier_Injected(ref ParticleSystem.MainModule _unity_self) { }

	private static void set_startLifetimeMultiplier_Injected(ref ParticleSystem.MainModule _unity_self, float value) { }

	private static void get_startSpeed_Injected(ref ParticleSystem.MainModule _unity_self, out ParticleSystem.MinMaxCurve ret) { }

	private static void set_startSpeed_Injected(ref ParticleSystem.MainModule _unity_self, ref ParticleSystem.MinMaxCurve value) { }

	private static float get_startSpeedMultiplier_Injected(ref ParticleSystem.MainModule _unity_self) { }

	private static void set_startSpeedMultiplier_Injected(ref ParticleSystem.MainModule _unity_self, float value) { }

	private static void get_startSize_Injected(ref ParticleSystem.MainModule _unity_self, out ParticleSystem.MinMaxCurve ret) { }

	private static void set_startSize_Injected(ref ParticleSystem.MainModule _unity_self, ref ParticleSystem.MinMaxCurve value) { }

	private static float get_startSizeMultiplier_Injected(ref ParticleSystem.MainModule _unity_self) { }

	private static void set_startSizeMultiplier_Injected(ref ParticleSystem.MainModule _unity_self, float value) { }

	private static void get_startColor_Injected(ref ParticleSystem.MainModule _unity_self, out ParticleSystem.MinMaxGradient ret) { }

	private static void set_startColor_Injected(ref ParticleSystem.MainModule _unity_self, ref ParticleSystem.MinMaxGradient value) { }

	private static float get_gravityModifierMultiplier_Injected(ref ParticleSystem.MainModule _unity_self) { }

	private static void set_gravityModifierMultiplier_Injected(ref ParticleSystem.MainModule _unity_self, float value) { }

	private static void set_simulationSpace_Injected(ref ParticleSystem.MainModule _unity_self, ParticleSystemSimulationSpace value) { }

	private static bool get_playOnAwake_Injected(ref ParticleSystem.MainModule _unity_self) { }

	private static int get_maxParticles_Injected(ref ParticleSystem.MainModule _unity_self) { }

	private static void set_maxParticles_Injected(ref ParticleSystem.MainModule _unity_self, int value) { }

	private static void set_cullingMode_Injected(ref ParticleSystem.MainModule _unity_self, ParticleSystemCullingMode value) { }

}

public struct ParticleSystem.EmissionModule // TypeDefIndex: 4529
{	internal ParticleSystem m_ParticleSystem; // 0x0

	[ObsoleteAttribute] // RVA: 0xEF460 Offset: 0xEE860 VA: 0x1800EF460
	public ParticleSystem.MinMaxCurve rate { set; }
	public bool enabled { get; set; }
	public ParticleSystem.MinMaxCurve rateOverTime { get; set; }
	public float rateOverTimeMultiplier { get; set; }


	public void set_rate(ParticleSystem.MinMaxCurve value) { }

	internal void .ctor(ParticleSystem particleSystem) { }

	public bool get_enabled() { }

	public void set_enabled(bool value) { }

	public ParticleSystem.MinMaxCurve get_rateOverTime() { }

	public void set_rateOverTime(ParticleSystem.MinMaxCurve value) { }

	public float get_rateOverTimeMultiplier() { }

	public void set_rateOverTimeMultiplier(float value) { }

	public void SetBurst(int index, ParticleSystem.Burst burst) { }

	public ParticleSystem.Burst GetBurst(int index) { }

	private static bool get_enabled_Injected(ref ParticleSystem.EmissionModule _unity_self) { }

	private static void set_enabled_Injected(ref ParticleSystem.EmissionModule _unity_self, bool value) { }

	private static void get_rateOverTime_Injected(ref ParticleSystem.EmissionModule _unity_self, out ParticleSystem.MinMaxCurve ret) { }

	private static void set_rateOverTime_Injected(ref ParticleSystem.EmissionModule _unity_self, ref ParticleSystem.MinMaxCurve value) { }

	private static float get_rateOverTimeMultiplier_Injected(ref ParticleSystem.EmissionModule _unity_self) { }

	private static void set_rateOverTimeMultiplier_Injected(ref ParticleSystem.EmissionModule _unity_self, float value) { }

	private static void SetBurst_Injected(ref ParticleSystem.EmissionModule _unity_self, int index, ref ParticleSystem.Burst burst) { }

	private static void GetBurst_Injected(ref ParticleSystem.EmissionModule _unity_self, int index, out ParticleSystem.Burst ret) { }

}

public struct ParticleSystem.ShapeModule // TypeDefIndex: 4530
{	internal ParticleSystem m_ParticleSystem; // 0x0

	public ParticleSystemShapeType shapeType { set; }
	public float randomDirectionAmount { set; }
	public float radius { get; set; }
	public float angle { set; }
	public float length { set; }
	public MeshRenderer meshRenderer { set; }
	public float arc { set; }
	public Vector3 position { set; }
	public Vector3 rotation { get; }
	public Vector3 scale { set; }


	internal void .ctor(ParticleSystem particleSystem) { }

	public void set_shapeType(ParticleSystemShapeType value) { }

	public void set_randomDirectionAmount(float value) { }

	public float get_radius() { }

	public void set_radius(float value) { }

	public void set_angle(float value) { }

	public void set_length(float value) { }

	public void set_meshRenderer(MeshRenderer value) { }

	public void set_arc(float value) { }

	public void set_position(Vector3 value) { }

	public Vector3 get_rotation() { }

	public void set_scale(Vector3 value) { }

	private static void set_shapeType_Injected(ref ParticleSystem.ShapeModule _unity_self, ParticleSystemShapeType value) { }

	private static void set_randomDirectionAmount_Injected(ref ParticleSystem.ShapeModule _unity_self, float value) { }

	private static float get_radius_Injected(ref ParticleSystem.ShapeModule _unity_self) { }

	private static void set_radius_Injected(ref ParticleSystem.ShapeModule _unity_self, float value) { }

	private static void set_angle_Injected(ref ParticleSystem.ShapeModule _unity_self, float value) { }

	private static void set_length_Injected(ref ParticleSystem.ShapeModule _unity_self, float value) { }

	private static void set_meshRenderer_Injected(ref ParticleSystem.ShapeModule _unity_self, MeshRenderer value) { }

	private static void set_arc_Injected(ref ParticleSystem.ShapeModule _unity_self, float value) { }

	private static void set_position_Injected(ref ParticleSystem.ShapeModule _unity_self, ref Vector3 value) { }

	private static void get_rotation_Injected(ref ParticleSystem.ShapeModule _unity_self, out Vector3 ret) { }

	private static void set_scale_Injected(ref ParticleSystem.ShapeModule _unity_self, ref Vector3 value) { }

}

public struct ParticleSystem.Particle // TypeDefIndex: 4531
{	private Vector3 m_Position; // 0x0
	private Vector3 m_Velocity; // 0xC
	private Vector3 m_AnimatedVelocity; // 0x18
	private Vector3 m_InitialVelocity; // 0x24
	private Vector3 m_AxisOfRotation; // 0x30
	private Vector3 m_Rotation; // 0x3C
	private Vector3 m_AngularVelocity; // 0x48
	private Vector3 m_StartSize; // 0x54
	private Color32 m_StartColor; // 0x60
	private uint m_RandomSeed; // 0x64
	private uint m_ParentRandomSeed; // 0x68
	private float m_Lifetime; // 0x6C
	private float m_StartLifetime; // 0x70
	private int m_MeshIndex; // 0x74
	private float m_EmitAccumulator0; // 0x78
	private float m_EmitAccumulator1; // 0x7C
	private uint m_Flags; // 0x80

	[ObsoleteAttribute] // RVA: 0xEF840 Offset: 0xEEC40 VA: 0x1800EF840
	public float lifetime { set; }
	public Vector3 position { set; }
	public Vector3 velocity { set; }
	public float remainingLifetime { set; }
	public float startLifetime { set; }
	public Color32 startColor { set; }
	public uint randomSeed { set; }
	public float startSize { set; }
	public Vector3 rotation3D { set; }
	public Vector3 angularVelocity3D { set; }


	public void set_lifetime(float value) { }

	public void set_position(Vector3 value) { }

	public void set_velocity(Vector3 value) { }

	public void set_remainingLifetime(float value) { }

	public void set_startLifetime(float value) { }

	public void set_startColor(Color32 value) { }

	public void set_randomSeed(uint value) { }

	public void set_startSize(float value) { }

	public void set_rotation3D(Vector3 value) { }

	public void set_angularVelocity3D(Vector3 value) { }

}

public struct ParticleSystem.Burst // TypeDefIndex: 4532
{	private float m_Time; // 0x0
	private ParticleSystem.MinMaxCurve m_Count; // 0x8
	private int m_RepeatCount; // 0x28
	private float m_RepeatInterval; // 0x2C
	private float m_InvProbability; // 0x30

	public float probability { set; }


	public void set_probability(float value) { }

}

public struct ParticleSystem.MinMaxCurve // TypeDefIndex: 4533
{	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private ParticleSystemCurveMode m_Mode; // 0x0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float m_CurveMultiplier; // 0x4
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private AnimationCurve m_CurveMin; // 0x8
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private AnimationCurve m_CurveMax; // 0x10
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float m_ConstantMin; // 0x18
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float m_ConstantMax; // 0x1C

	public ParticleSystemCurveMode mode { set; }
	public float constantMax { get; set; }
	public float constantMin { set; }
	public float constant { get; set; }


	public void .ctor(float constant) { }

	public void set_mode(ParticleSystemCurveMode value) { }

	public float get_constantMax() { }

	public void set_constantMax(float value) { }

	public void set_constantMin(float value) { }

	public float get_constant() { }

	public void set_constant(float value) { }

	public static ParticleSystem.MinMaxCurve op_Implicit(float constant) { }

}

public struct ParticleSystem.MinMaxGradient // TypeDefIndex: 4534
{	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private ParticleSystemGradientMode m_Mode; // 0x0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Gradient m_GradientMin; // 0x8
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Gradient m_GradientMax; // 0x10
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Color m_ColorMin; // 0x18
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Color m_ColorMax; // 0x28

	public ParticleSystemGradientMode mode { set; }
	public Color color { get; set; }
	public Gradient gradient { set; }


	public void .ctor(Color color) { }

	public void .ctor(Gradient gradient) { }

	public void set_mode(ParticleSystemGradientMode value) { }

	public Color get_color() { }

	public void set_color(Color value) { }

	public void set_gradient(Gradient value) { }

	public static ParticleSystem.MinMaxGradient op_Implicit(Color color) { }

	public static ParticleSystem.MinMaxGradient op_Implicit(Gradient gradient) { }

}

public struct ParticleSystem.EmitParams // TypeDefIndex: 4535
{	[NativeNameAttribute] // RVA: 0xF0430 Offset: 0xEF830 VA: 0x1800F0430
	private ParticleSystem.Particle m_Particle; // 0x0
	[NativeNameAttribute] // RVA: 0xF0550 Offset: 0xEF950 VA: 0x1800F0550
	private bool m_PositionSet; // 0x84
	[NativeNameAttribute] // RVA: 0xF0700 Offset: 0xEFB00 VA: 0x1800F0700
	private bool m_VelocitySet; // 0x85
	[NativeNameAttribute] // RVA: 0xF0820 Offset: 0xEFC20 VA: 0x1800F0820
	private bool m_AxisOfRotationSet; // 0x86
	[NativeNameAttribute] // RVA: 0xF0930 Offset: 0xEFD30 VA: 0x1800F0930
	private bool m_RotationSet; // 0x87
	[NativeNameAttribute] // RVA: 0xF0AA0 Offset: 0xEFEA0 VA: 0x1800F0AA0
	private bool m_AngularVelocitySet; // 0x88
	[NativeNameAttribute] // RVA: 0xF0C80 Offset: 0xF0080 VA: 0x1800F0C80
	private bool m_StartSizeSet; // 0x89
	[NativeNameAttribute] // RVA: 0xF0E90 Offset: 0xF0290 VA: 0x1800F0E90
	private bool m_StartColorSet; // 0x8A
	[NativeNameAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private bool m_RandomSeedSet; // 0x8B
	[NativeNameAttribute] // RVA: 0x6F4A0 Offset: 0x6E8A0 VA: 0x18006F4A0
	private bool m_StartLifetimeSet; // 0x8C
	[NativeNameAttribute] // RVA: 0x6F700 Offset: 0x6EB00 VA: 0x18006F700
	private bool m_MeshIndexSet; // 0x8D
	[NativeNameAttribute] // RVA: 0x6FB20 Offset: 0x6EF20 VA: 0x18006FB20
	private bool m_ApplyShapeToPosition; // 0x8E

	public Vector3 position { set; }
	public float startSize { set; }
	public Color32 startColor { set; }


	public void set_position(Vector3 value) { }

	public void set_startSize(float value) { }

	public void set_startColor(Color32 value) { }

}

public struct ParticleSystem.ColorOverLifetimeModule // TypeDefIndex: 4536
{	internal ParticleSystem m_ParticleSystem; // 0x0

	public ParticleSystem.MinMaxGradient color { set; }


	internal void .ctor(ParticleSystem particleSystem) { }

	public void set_color(ParticleSystem.MinMaxGradient value) { }

	private static void set_color_Injected(ref ParticleSystem.ColorOverLifetimeModule _unity_self, ref ParticleSystem.MinMaxGradient value) { }

}

public struct ParticleSystem.CollisionModule // TypeDefIndex: 4537
{	internal ParticleSystem m_ParticleSystem; // 0x0

	public bool enabled { get; set; }
	public ParticleSystemCollisionQuality quality { set; }


	internal void .ctor(ParticleSystem particleSystem) { }

	public bool get_enabled() { }

	public void set_enabled(bool value) { }

	public void set_quality(ParticleSystemCollisionQuality value) { }

	private static bool get_enabled_Injected(ref ParticleSystem.CollisionModule _unity_self) { }

	private static void set_enabled_Injected(ref ParticleSystem.CollisionModule _unity_self, bool value) { }

	private static void set_quality_Injected(ref ParticleSystem.CollisionModule _unity_self, ParticleSystemCollisionQuality value) { }

}

