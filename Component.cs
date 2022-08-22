public class Component : MarshalByRefObject, IComponent, IDisposable // TypeDefIndex: 2677
{	// Fields
	private static readonly object EventDisposed; // 0x0
	private ISite site; // 0x18
	private EventHandlerList events; // 0x20

	// Properties
	protected virtual bool CanRaiseEvents { get; }
	internal bool CanRaiseEventsInternal { get; }
	protected EventHandlerList Events { get; }
	[DesignerSerializationVisibilityAttribute] // RVA: 0x9E850 Offset: 0x9DC50 VA: 0x18009E850
	[BrowsableAttribute] // RVA: 0x9E850 Offset: 0x9DC50 VA: 0x18009E850
	public virtual ISite Site { get; }
	[DesignerSerializationVisibilityAttribute] // RVA: 0x9E850 Offset: 0x9DC50 VA: 0x18009E850
	[BrowsableAttribute] // RVA: 0x9E850 Offset: 0x9DC50 VA: 0x18009E850
	protected bool DesignMode { get; }

	// Methods

	// RVA: 0x15BFA80 Offset: 0x15BE080 VA: 0x1815BFA80 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 8
	protected virtual bool get_CanRaiseEvents() { }

	// RVA: 0x4C2860 Offset: 0x4C0E60 VA: 0x1804C2860
	internal bool get_CanRaiseEventsInternal() { }

	// RVA: 0x15BFD00 Offset: 0x15BE300 VA: 0x1815BFD00
	protected EventHandlerList get_Events() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 9
	public virtual ISite get_Site() { }

	// RVA: 0x15BFA10 Offset: 0x15BE010 VA: 0x1815BFA10 Slot: 7
	public void Dispose() { }

	// RVA: 0x15BF830 Offset: 0x15BDE30 VA: 0x1815BF830 Slot: 10
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x15BFB20 Offset: 0x15BE120 VA: 0x1815BFB20 Slot: 11
	protected virtual object GetService(Type service) { }

	// RVA: 0x15BFCB0 Offset: 0x15BE2B0 VA: 0x1815BFCB0
	protected bool get_DesignMode() { }

	// RVA: 0x15BFB80 Offset: 0x15BE180 VA: 0x1815BFB80 Slot: 3
	public override string ToString() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x15BFC50 Offset: 0x15BE250 VA: 0x1815BFC50
	private static void .cctor() { }

}

public class Component : Object // TypeDefIndex: 3508
{	// Properties
	public Transform transform { get; }
	public GameObject gameObject { get; }

	// Methods

	[FreeFunctionAttribute] // RVA: 0xB9A30 Offset: 0xB8E30 VA: 0x1800B9A30
	// RVA: 0x18258D0 Offset: 0x1823ED0 VA: 0x1818258D0
	public Transform get_transform() { }

	[FreeFunctionAttribute] // RVA: 0xB9AA0 Offset: 0xB8EA0 VA: 0x1800B9AA0
	// RVA: 0x1825890 Offset: 0x1823E90 VA: 0x181825890
	public GameObject get_gameObject() { }

	[TypeInferenceRuleAttribute] // RVA: 0xB9C80 Offset: 0xB9080 VA: 0x1800B9C80
	// RVA: 0x1825470 Offset: 0x1823A70 VA: 0x181825470
	public Component GetComponent(Type type) { }

	[FreeFunctionAttribute] // RVA: 0xB9CF0 Offset: 0xB90F0 VA: 0x1800B9CF0
	// RVA: 0x1825300 Offset: 0x1823900 VA: 0x181825300
	internal void GetComponentFastPath(Type type, IntPtr oneFurtherThanResultValue) { }

	// RVA: -1 Offset: -1
	public T GetComponent<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x159ED70 Offset: 0x159D370 VA: 0x18159ED70
	|-Component.GetComponent<AIInformationZone>
	|-Component.GetComponent<AddNewEventUIButton>
	|-Component.GetComponent<AddNewStateUIButton>
	|-Component.GetComponent<AdvancedChristmasLights>
	|-Component.GetComponent<AmbienceZone>
	|-Component.GetComponent<AmbientLightLOD>
	|-Component.GetComponent<AnimalSkin>
	|-Component.GetComponent<AnimationEvents>
	|-Component.GetComponent<ArcadeEntity>
	|-Component.GetComponent<ArticulatedOccludee>
	|-Component.GetComponent<BaseCollision>
	|-Component.GetComponent<BaseCombatEntity>
	|-Component.GetComponent<BaseEntity>
	|-Component.GetComponent<BaseEventUI>
	|-Component.GetComponent<BaseMelee>
	|-Component.GetComponent<BaseMeshPaintable>
	|-Component.GetComponent<BasePlayer>
	|-Component.GetComponent<BaseProjectile>
	|-Component.GetComponent<BaseStateUI>
	|-Component.GetComponent<BowWeapon>
	|-Component.GetComponent<BuildingBlock>
	|-Component.GetComponent<CardReader>
	|-Component.GetComponent<CargoShip>
	|-Component.GetComponent<ChippyArcadeGame>
	|-Component.GetComponent<ChippyBoss>
	|-Component.GetComponent<CollectableEasterEgg>
	|-Component.GetComponent<ColliderInfo>
	|-Component.GetComponent<CommandBufferManager>
	|-Component.GetComponent<CommunityEntity.FadeOut>
	|-Component.GetComponent<ComputerStation>
	|-Component.GetComponent<CoverageQueryFlare>
	|-Component.GetComponent<DamageRenderer>
	|-Component.GetComponent<DecorComponent>
	|-Component.GetComponent<DeferredDecal>
	|-Component.GetComponent<Deployable>
	|-Component.GetComponent<DistanceFlareLOD>
	|-Component.GetComponent<Door>
	|-Component.GetComponent<DudTimedExplosive>
	|-Component.GetComponent<DungeonBaseLink>
	|-Component.GetComponent<ERSurfaceScript>
	|-Component.GetComponent<ERModularBase>
	|-Component.GetComponent<ERModularRoad>
	|-Component.GetComponent<ERPrefabInstance>
	|-Component.GetComponent<ERRoundabouts>
	|-Component.GetComponent<ERSideObjectInstance>
	|-Component.GetComponent<EggSwap>
	|-Component.GetComponent<ElectricBattery>
	|-Component.GetComponent<EnumListItemUI>
	|-Component.GetComponent<FPSGraph>
	|-Component.GetComponent<Skeleton>
	|-Component.GetComponent<FishingBobber>
	|-Component.GetComponent<FishingRodViewmodel>
	|-Component.GetComponent<FootstepEffects>
	|-Component.GetComponent<IProvider>
	|-Component.GetComponent<Gib>
	|-Component.GetComponent<GlassPane>
	|-Component.GetComponent<GrenadeWeapon>
	|-Component.GetComponent<GrowableEntity>
	|-Component.GetComponent<Hammer>
	|-Component.GetComponent<HeldEntity>
	|-Component.GetComponent<HideIfOwnerFirstPerson>
	|-Component.GetComponent<HitboxSystem>
	|-Component.GetComponent<HorseCorpse>
	|-Component.GetComponent<IAIDesign>
	|-Component.GetComponent<IAudioConnectionSource>
	|-Component.GetComponent<IBatchingHandler>
	|-Component.GetComponent<IDraggable>
	|-Component.GetComponent<IItemContainerEntity>
	|-Component.GetComponent<IOEntity>
	|-Component.GetComponent<IRFObject>
	|-Component.GetComponent<IRemoteControllable>
	|-Component.GetComponent<ImageEffectComposite>
	|-Component.GetComponent<Impostor>
	|-Component.GetComponent<InstrumentKeyController>
	|-Component.GetComponent<InstrumentViewmodel>
	|-Component.GetComponent<InvisibleVendingMachine>
	|-Component.GetComponent<IronSights>
	|-Component.GetComponent<ItemBlueprint>
	|-Component.GetComponent<ItemCrafter>
	|-Component.GetComponent<ItemDefinition>
	|-Component.GetComponent<ItemFootstepSounds>
	|-Component.GetComponent<ItemIcon>
	|-Component.GetComponent<ItemModAnimalEquipment>
	|-Component.GetComponent<ItemModAssociatedEntityMobile>
	|-Component.GetComponent<ItemModChildIO>
	|-Component.GetComponent<ItemModConsumable>
	|-Component.GetComponent<ItemModConsume>
	|-Component.GetComponent<ItemModContainer>
	|-Component.GetComponent<ItemModDeployable>
	|-Component.GetComponent<ItemModEntity>
	|-Component.GetComponent<ItemModKeycard>
	|-Component.GetComponent<ItemModPetStats>
	|-Component.GetComponent<ItemModProjectile>
	|-Component.GetComponent<ItemModRFListener>
	|-Component.GetComponent<ItemModSign>
	|-Component.GetComponent<ItemModWearable>
	|-Component.GetComponent<LODComponent>
	|-Component.GetComponent<LODComponentParticleSystem>
	|-Component.GetComponent<LightEx>
	|-Component.GetComponent<LightLOD>
	|-Component.GetComponent<LightOccludee>
	|-Component.GetComponent<LiquidContainer>
	|-Component.GetComponent<LiquidWeaponEffects>
	|-Component.GetComponent<LootPanel>
	|-Component.GetComponent<MagnetLiftable>
	|-Component.GetComponent<MaterialColorLerp>
	|-Component.GetComponent<MeshLOD>
	|-Component.GetComponent<Model>
	|-Component.GetComponent<MorphCache>
	|-Component.GetComponent<NeedsCursor>
	|-Component.GetComponent<NeedsKeyboard>
	|-Component.GetComponent<OnePoleLowpassFilter>
	|-Component.GetComponent<PagerEntity>
	|-Component.GetComponent<PaintableItem>
	|-Component.GetComponent<Planner>
	|-Component.GetComponent<PlanterBox>
	|-Component.GetComponent<PlayerBlueprints>
	|-Component.GetComponent<PlayerEyes>
	|-Component.GetComponent<PlayerInput>
	|-Component.GetComponent<PlayerInventory>
	|-Component.GetComponent<PlayerLoot>
	|-Component.GetComponent<PlayerMetabolism>
	|-Component.GetComponent<PlayerModel>
	|-Component.GetComponent<PlayerModelHair>
	|-Component.GetComponent<PlayerModelHairCap>
	|-Component.GetComponent<PlayerModifiers>
	|-Component.GetComponent<PlayerVoiceRecorder>
	|-Component.GetComponent<PlayerVoiceSpeaker>
	|-Component.GetComponent<PlayingCardsViewmodel>
	|-Component.GetComponent<PostOpaqueDepth>
	|-Component.GetComponent<PowerLineWireConnectionHelper>
	|-Component.GetComponent<Projectile>
	|-Component.GetComponent<RealmedRemove>
	|-Component.GetComponent<RendererBatch>
	|-Component.GetComponent<CoverPointVolume>
	|-Component.GetComponent<IEntity>
	|-Component.GetComponent<ItemModEngineItem>
	|-Component.GetComponent<ItemModVehicleModule>
	|-Component.GetComponent<RustButton>
	|-Component.GetComponent<RustImageButton>
	|-Component.GetComponent<RustInput>
	|-Component.GetComponent<RustLayout>
	|-Component.GetComponent<RustText>
	|-Component.GetComponent<SteamInventoryItem>
	|-Component.GetComponent<WorkshopPlayerPreview>
	|-Component.GetComponent<SedanWheelSmoke>
	|-Component.GetComponent<ServerHistoryItem>
	|-Component.GetComponent<SkinnedMultiMesh>
	|-Component.GetComponent<Sound>
	|-Component.GetComponent<SoundFadeHQAudioFilter>
	|-Component.GetComponent<SpriteArcadeEntity>
	|-Component.GetComponent<SteamInventory>
	|-Component.GetComponent<SwapArrows>
	|-Component.GetComponent<SwapKeycard>
	|-Component.GetComponent<SwapRPG>
	|-Component.GetComponent<TMP_InputField>
	|-Component.GetComponent<TMP_Text>
	|-Component.GetComponent<TextMeshPro>
	|-Component.GetComponent<TextMeshProUGUI>
	|-Component.GetComponent<TOD_Animation>
	|-Component.GetComponent<TOD_Components>
	|-Component.GetComponent<TOD_Resources>
	|-Component.GetComponent<TOD_Scattering>
	|-Component.GetComponent<TOD_Sky>
	|-Component.GetComponent<TOD_Time>
	|-Component.GetComponent<TechTreeDialog>
	|-Component.GetComponent<TechTreeEntry>
	|-Component.GetComponent<TerrainAlphaMap>
	|-Component.GetComponent<TerrainBiomeMap>
	|-Component.GetComponent<TerrainBlendMap>
	|-Component.GetComponent<TerrainCollision>
	|-Component.GetComponent<TerrainCollisionProxy>
	|-Component.GetComponent<TerrainColors>
	|-Component.GetComponent<TerrainDistanceMap>
	|-Component.GetComponent<TerrainHeightMap>
	|-Component.GetComponent<TerrainMeta>
	|-Component.GetComponent<TerrainPath>
	|-Component.GetComponent<TerrainPhysics>
	|-Component.GetComponent<TerrainPlacementMap>
	|-Component.GetComponent<TerrainQuality>
	|-Component.GetComponent<TerrainSplatMap>
	|-Component.GetComponent<TerrainTexturing>
	|-Component.GetComponent<TerrainTopologyMap>
	|-Component.GetComponent<TerrainWaterMap>
	|-Component.GetComponent<Tooltip>
	|-Component.GetComponent<TreadAnimator>
	|-Component.GetComponent<TriggerLadder>
	|-Component.GetComponent<UIEscapeCapture>
	|-Component.GetComponent<Animation>
	|-Component.GetComponent<Animator>
	|-Component.GetComponent<AudioSource>
	|-Component.GetComponent<BoxCollider>
	|-Component.GetComponent<Camera>
	|-Component.GetComponent<Canvas>
	|-Component.GetComponent<CanvasGroup>
	|-Component.GetComponent<CanvasRenderer>
	|-Component.GetComponent<CapsuleCollider>
	|-Component.GetComponent<Collider>
	|-Component.GetComponent<EventSystem>
	|-Component.GetComponent<LODGroup>
	|-Component.GetComponent<Light>
	|-Component.GetComponent<LineRenderer>
	|-Component.GetComponent<MeshCollider>
	|-Component.GetComponent<MeshFilter>
	|-Component.GetComponent<MeshRenderer>
	|-Component.GetComponent<ParticleSystem>
	|-Component.GetComponent<ParticleSystemRenderer>
	|-Component.GetComponent<Projector>
	|-Component.GetComponent<RectTransform>
	|-Component.GetComponent<ReflectionProbe>
	|-Component.GetComponent<Renderer>
	|-Component.GetComponent<PostProcessLayer>
	|-Component.GetComponent<PostProcessVolume>
	|-Component.GetComponent<Rigidbody>
	|-Component.GetComponent<SkinnedMeshRenderer>
	|-Component.GetComponent<SphereCollider>
	|-Component.GetComponent<SpriteRenderer>
	|-Component.GetComponent<Terrain>
	|-Component.GetComponent<TerrainCollider>
	|-Component.GetComponent<TrailRenderer>
	|-Component.GetComponent<Transform>
	|-Component.GetComponent<Button>
	|-Component.GetComponent<CanvasScaler>
	|-Component.GetComponent<Graphic>
	|-Component.GetComponent<GraphicRaycaster>
	|-Component.GetComponent<ILayoutController>
	|-Component.GetComponent<Image>
	|-Component.GetComponent<InputField>
	|-Component.GetComponent<LayoutElement>
	|-Component.GetComponent<Mask>
	|-Component.GetComponent<RawImage>
	|-Component.GetComponent<ScrollRect>
	|-Component.GetComponent<Slider>
	|-Component.GetComponent<Text>
	|-Component.GetComponent<Toggle>
	|-Component.GetComponent<ToggleGroup>
	|-Component.GetComponent<VerticalLayoutGroup>
	|-Component.GetComponent<VideoPlayer>
	|-Component.GetComponent<WindZone>
	|-Component.GetComponent<TriggerZone>
	|-Component.GetComponent<VolumetricLightBeam>
	|-Component.GetComponent<VehicleModuleEngine>
	|-Component.GetComponent<VehicleModuleInformationPanel.IVehicleModuleInfo>
	|-Component.GetComponent<VehicleSpawner>
	|-Component.GetComponent<VertexColorStream>
	|-Component.GetComponent<ViewModel>
	|-Component.GetComponent<ViewmodelAspectOffset>
	|-Component.GetComponent<ViewmodelAttachment>
	|-Component.GetComponent<ViewmodelBob>
	|-Component.GetComponent<ViewmodelLower>
	|-Component.GetComponent<ViewmodelMountedAnchor>
	|-Component.GetComponent<ViewmodelPunch>
	|-Component.GetComponent<ViewmodelSway>
	|-Component.GetComponent<WaterCollision>
	|-Component.GetComponent<WaterDynamics>
	|-Component.GetComponent<WearableHairCap>
	|-Component.GetComponent<WearableReplacementByRace>
	|-Component.GetComponent<WearableShadowLod>
	|-Component.GetComponent<WireTool>
	|-Component.GetComponent<flamethrowerFire>
	|-Component.GetComponent<v_chainsaw>
	|-Component.GetComponent<object>
	*/

	// RVA: -1 Offset: -1
	public bool TryGetComponent<T>(out T component) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBEEB50 Offset: 0xBED150 VA: 0x180BEEB50
	|-Component.TryGetComponent<BeltBarIcon>
	|-Component.TryGetComponent<BoneRetarget>
	|-Component.TryGetComponent<ColliderInfo>
	|-Component.TryGetComponent<ConnectedSpeaker>
	|-Component.TryGetComponent<DragMeCustomParent>
	|-Component.TryGetComponent<DungeonGridInfo>
	|-Component.TryGetComponent<HitboxSystem>
	|-Component.TryGetComponent<IAnimationEventReceiver>
	|-Component.TryGetComponent<IAudioConnectionSource>
	|-Component.TryGetComponent<IAutoLayout>
	|-Component.TryGetComponent<IContainerSounds>
	|-Component.TryGetComponent<IPropRenderNotify>
	|-Component.TryGetComponent<InstrumentKeyController>
	|-Component.TryGetComponent<ItemModCassette>
	|-Component.TryGetComponent<ItemModCompostable>
	|-Component.TryGetComponent<ItemModDeployable>
	|-Component.TryGetComponent<ItemModEntity>
	|-Component.TryGetComponent<ItemModProjectile>
	|-Component.TryGetComponent<LootContainer>
	|-Component.TryGetComponent<NewsParagraph>
	|-Component.TryGetComponent<RendererLOD>
	|-Component.TryGetComponent<SprayCanViewmodel>
	|-Component.TryGetComponent<SwapKeycard>
	|-Component.TryGetComponent<object>
	|-Component.TryGetComponent<MeshFilter>
	|-Component.TryGetComponent<ParticleSystem>
	|-Component.TryGetComponent<Renderer>
	|-Component.TryGetComponent<ViewModel>
	|-Component.TryGetComponent<WaterBody>
	|-Component.TryGetComponent<v_chainsaw>
	*/

	[TypeInferenceRuleAttribute] // RVA: 0xB9C80 Offset: 0xB9080 VA: 0x1800B9C80
	// RVA: 0x1825360 Offset: 0x1823960 VA: 0x181825360
	public Component GetComponentInChildren(Type t, bool includeInactive) { }

	// RVA: -1 Offset: -1
	public T GetComponentInChildren<T>(bool includeInactive) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x159EAF0 Offset: 0x159D0F0 VA: 0x18159EAF0
	|-Component.GetComponentInChildren<VirtualScroll>
	|-Component.GetComponentInChildren<Publisher>
	|-Component.GetComponentInChildren<WorkshopView>
	|-Component.GetComponentInChildren<MeshRenderer>
	|-Component.GetComponentInChildren<SkinnedMeshRenderer>
	|-Component.GetComponentInChildren<object>
	*/

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	public T GetComponentInChildren<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x159EBD0 Offset: 0x159D1D0 VA: 0x18159EBD0
	|-Component.GetComponentInChildren<AnimationEvents>
	|-Component.GetComponentInChildren<BlendedLoopEngineSound>
	|-Component.GetComponentInChildren<ConstructionPlaceholder>
	|-Component.GetComponentInChildren<DungeonBaseLink>
	|-Component.GetComponentInChildren<DungeonGridInfo>
	|-Component.GetComponentInChildren<DungeonGridLink>
	|-Component.GetComponentInChildren<DungeonVolume>
	|-Component.GetComponentInChildren<IAirSupply>
	|-Component.GetComponentInChildren<Impostor>
	|-Component.GetComponentInChildren<LODComponent>
	|-Component.GetComponentInChildren<MeshPaintController>
	|-Component.GetComponentInChildren<MeshPaintableSource>
	|-Component.GetComponentInChildren<NeedsCursor>
	|-Component.GetComponentInChildren<NeedsMouseButtons>
	|-Component.GetComponentInChildren<NeedsMouseWheel>
	|-Component.GetComponentInChildren<OutlineObject>
	|-Component.GetComponentInChildren<RustButton>
	|-Component.GetComponentInChildren<SteamInventoryItem>
	|-Component.GetComponentInChildren<TextMeshProUGUI>
	|-Component.GetComponentInChildren<TreeLOD>
	|-Component.GetComponentInChildren<Animator>
	|-Component.GetComponentInChildren<CanvasGroup>
	|-Component.GetComponentInChildren<Collider>
	|-Component.GetComponentInChildren<EventSystem>
	|-Component.GetComponentInChildren<TrailRenderer>
	|-Component.GetComponentInChildren<ScrollRect>
	|-Component.GetComponentInChildren<Text>
	|-Component.GetComponentInChildren<Toggle>
	|-Component.GetComponentInChildren<WaterBody>
	|-Component.GetComponentInChildren<object>
	*/

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1825550 Offset: 0x1823B50 VA: 0x181825550
	public Component[] GetComponentsInChildren(Type t) { }

	// RVA: -1 Offset: -1
	public T[] GetComponentsInChildren<T>(bool includeInactive) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A37770 Offset: 0x1A35D70 VA: 0x181A37770
	|-Component.GetComponentsInChildren<AchievementTodo>
	|-Component.GetComponentsInChildren<BaseScreenShake>
	|-Component.GetComponentsInChildren<BaseViewModel>
	|-Component.GetComponentsInChildren<BuildingProximity>
	|-Component.GetComponentsInChildren<EntityComponentBase>
	|-Component.GetComponentsInChildren<IOnPostNetworkUpdate>
	|-Component.GetComponentsInChildren<IVitalNotice>
	|-Component.GetComponentsInChildren<ItemInformationPanel>
	|-Component.GetComponentsInChildren<ItemMod>
	|-Component.GetComponentsInChildren<MissionsHUDToDo>
	|-Component.GetComponentsInChildren<ModelConditionTest>
	|-Component.GetComponentsInChildren<ProceduralComponent>
	|-Component.GetComponentsInChildren<ProtectionValue>
	|-Component.GetComponentsInChildren<RendererBatch>
	|-Component.GetComponentsInChildren<NetGraphRow>
	|-Component.GetComponentsInChildren<MaterialRow>
	|-Component.GetComponentsInChildren<ServerBrowserList>
	|-Component.GetComponentsInChildren<SingletonComponent>
	|-Component.GetComponentsInChildren<SocketHandle>
	|-Component.GetComponentsInChildren<SocketMod>
	|-Component.GetComponentsInChildren<Socket_Base>
	|-Component.GetComponentsInChildren<SoundPlayer>
	|-Component.GetComponentsInChildren<TerrainPathConnect>
	|-Component.GetComponentsInChildren<AudioSource>
	|-Component.GetComponentsInChildren<Canvas>
	|-Component.GetComponentsInChildren<LODGroup>
	|-Component.GetComponentsInChildren<Light>
	|-Component.GetComponentsInChildren<MeshCollider>
	|-Component.GetComponentsInChildren<MeshFilter>
	|-Component.GetComponentsInChildren<MeshRenderer>
	|-Component.GetComponentsInChildren<ParticleSystem>
	|-Component.GetComponentsInChildren<ParticleSystemRenderer>
	|-Component.GetComponentsInChildren<Rigidbody>
	|-Component.GetComponentsInChildren<SkinnedMeshRenderer>
	|-Component.GetComponentsInChildren<Transform>
	|-Component.GetComponentsInChildren<GraphicRaycaster>
	|-Component.GetComponentsInChildren<Toggle>
	|-Component.GetComponentsInChildren<ViewmodelIgniteToggle>
	|-Component.GetComponentsInChildren<object>
	*/

	// RVA: -1 Offset: -1
	public void GetComponentsInChildren<T>(bool includeInactive, List<T> result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5CB510 Offset: 0x5C9B10 VA: 0x1805CB510
	|-Component.GetComponentsInChildren<BaseVehicleModule>
	|-Component.GetComponentsInChildren<BoneRetarget>
	|-Component.GetComponentsInChildren<ComponentInfo>
	|-Component.GetComponentsInChildren<DungeonBaseSocket>
	|-Component.GetComponentsInChildren<DungeonVolume>
	|-Component.GetComponentsInChildren<EnvironmentVolume>
	|-Component.GetComponentsInChildren<SkeletonSkin>
	|-Component.GetComponentsInChildren<FruitScale>
	|-Component.GetComponentsInChildren<IRagdollInhert>
	|-Component.GetComponentsInChildren<LODComponent>
	|-Component.GetComponentsInChildren<LifeScale>
	|-Component.GetComponentsInChildren<LightOccludee>
	|-Component.GetComponentsInChildren<PlayerModelSkin>
	|-Component.GetComponentsInChildren<object>
	|-Component.GetComponentsInChildren<CharacterJoint>
	|-Component.GetComponentsInChildren<ConfigurableJoint>
	|-Component.GetComponentsInChildren<Joint>
	|-Component.GetComponentsInChildren<MeshRenderer>
	|-Component.GetComponentsInChildren<Renderer>
	|-Component.GetComponentsInChildren<Rigidbody>
	|-Component.GetComponentsInChildren<SkinnedMeshRenderer>
	|-Component.GetComponentsInChildren<Wearable>
	*/

	// RVA: -1 Offset: -1
	public T[] GetComponentsInChildren<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15A3F00 Offset: 0x15A2500 VA: 0x1815A3F00
	|-Component.GetComponentsInChildren<AIMovePoint>
	|-Component.GetComponentsInChildren<ArcadeEntity>
	|-Component.GetComponentsInChildren<BasePathNode>
	|-Component.GetComponentsInChildren<BlueprintCraftGridRow>
	|-Component.GetComponentsInChildren<ContactsEntry>
	|-Component.GetComponentsInChildren<DevControlsTab>
	|-Component.GetComponentsInChildren<HideIfScoped>
	|-Component.GetComponentsInChildren<HitNumber>
	|-Component.GetComponentsInChildren<ItemIcon>
	|-Component.GetComponentsInChildren<ItemTextValue>
	|-Component.GetComponentsInChildren<PathInterestNode>
	|-Component.GetComponentsInChildren<PathSpeedZone>
	|-Component.GetComponentsInChildren<NetGraphItem>
	|-Component.GetComponentsInChildren<RustText>
	|-Component.GetComponentsInChildren<TimelineMarker>
	|-Component.GetComponentsInChildren<ServerBrowserTag>
	|-Component.GetComponentsInChildren<Sound>
	|-Component.GetComponentsInChildren<TMP_SubMesh>
	|-Component.GetComponentsInChildren<TMP_SubMeshUI>
	|-Component.GetComponentsInChildren<NavMeshModifier>
	|-Component.GetComponentsInChildren<NavMeshModifierVolume>
	|-Component.GetComponentsInChildren<Collider>
	|-Component.GetComponentsInChildren<Light>
	|-Component.GetComponentsInChildren<MeshRenderer>
	|-Component.GetComponentsInChildren<ParticleSystem>
	|-Component.GetComponentsInChildren<Renderer>
	|-Component.GetComponentsInChildren<Rigidbody>
	|-Component.GetComponentsInChildren<TrailRenderer>
	|-Component.GetComponentsInChildren<Transform>
	|-Component.GetComponentsInChildren<Button>
	|-Component.GetComponentsInChildren<LayoutGroup>
	|-Component.GetComponentsInChildren<Toggle>
	|-Component.GetComponentsInChildren<VehicleLight>
	|-Component.GetComponentsInChildren<object>
	*/

	// RVA: -1 Offset: -1
	public void GetComponentsInChildren<T>(List<T> results) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5CB570 Offset: 0x5C9B70 VA: 0x1805CB570
	|-Component.GetComponentsInChildren<HitboxDefinition>
	|-Component.GetComponentsInChildren<ServerAdminUGCEntry>
	|-Component.GetComponentsInChildren<ServerAdminUGCEntryPattern>
	|-Component.GetComponentsInChildren<object>
	|-Component.GetComponentsInChildren<AudioSource>
	|-Component.GetComponentsInChildren<Collider>
	|-Component.GetComponentsInChildren<Component>
	|-Component.GetComponentsInChildren<MeshRenderer>
	|-Component.GetComponentsInChildren<ParticleSystem>
	|-Component.GetComponentsInChildren<Renderer>
	|-Component.GetComponentsInChildren<TrailRenderer>
	|-Component.GetComponentsInChildren<Transform>
	|-Component.GetComponentsInChildren<VolumetricLightBeam>
	*/

	[TypeInferenceRuleAttribute] // RVA: 0xB9C80 Offset: 0xB9080 VA: 0x1800B9C80
	// RVA: 0x18253F0 Offset: 0x18239F0 VA: 0x1818253F0
	public Component GetComponentInParent(Type t) { }

	// RVA: -1 Offset: -1
	public T GetComponentInParent<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x159ECA0 Offset: 0x159D2A0 VA: 0x18159ECA0
	|-Component.GetComponentInParent<BaseEntity>
	|-Component.GetComponentInParent<BaseEventUI>
	|-Component.GetComponentInParent<BaseMountable>
	|-Component.GetComponentInParent<BaseNetworkable>
	|-Component.GetComponentInParent<BaseVehicleModule>
	|-Component.GetComponentInParent<ChangeSignText>
	|-Component.GetComponentInParent<DeployableBoomBox>
	|-Component.GetComponentInParent<Skeleton>
	|-Component.GetComponentInParent<HitboxSystem>
	|-Component.GetComponentInParent<IronSights>
	|-Component.GetComponentInParent<LifeInfographic>
	|-Component.GetComponentInParent<MLRS>
	|-Component.GetComponentInParent<MapView>
	|-Component.GetComponentInParent<MonumentInfo>
	|-Component.GetComponentInParent<Ragdoll>
	|-Component.GetComponentInParent<WorkshopInterface>
	|-Component.GetComponentInParent<WorkshopItemEditor>
	|-Component.GetComponentInParent<Canvas>
	|-Component.GetComponentInParent<CanvasGroup>
	|-Component.GetComponentInParent<CanvasScaler>
	|-Component.GetComponentInParent<Dropdown>
	|-Component.GetComponentInParent<ILayoutGroup>
	|-Component.GetComponentInParent<object>
	*/

	// RVA: -1 Offset: -1
	public T[] GetComponentsInParent<T>(bool includeInactive) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A37770 Offset: 0x1A35D70 VA: 0x181A37770
	|-Component.GetComponentsInParent<object>
	*/

	// RVA: -1 Offset: -1
	public void GetComponentsInParent<T>(bool includeInactive, List<T> results) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5CB510 Offset: 0x5C9B10 VA: 0x1805CB510
	|-Component.GetComponentsInParent<object>
	|-Component.GetComponentsInParent<Canvas>
	|-Component.GetComponentsInParent<RectMask2D>
	*/

	// RVA: -1 Offset: -1
	public T[] GetComponentsInParent<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15A3F00 Offset: 0x15A2500 VA: 0x1815A3F00
	|-Component.GetComponentsInParent<BaseRaycaster>
	|-Component.GetComponentsInParent<object>
	*/

	// RVA: 0x18255B0 Offset: 0x1823BB0 VA: 0x1818255B0
	public Component[] GetComponents(Type type) { }

	[FreeFunctionAttribute] // RVA: 0xB9CF0 Offset: 0xB90F0 VA: 0x1800B9CF0
	// RVA: 0x18254F0 Offset: 0x1823AF0 VA: 0x1818254F0
	private void GetComponentsForListInternal(Type searchType, object resultList) { }

	// RVA: 0x18254F0 Offset: 0x1823AF0 VA: 0x1818254F0
	public void GetComponents(Type type, List<Component> results) { }

	// RVA: -1 Offset: -1
	public void GetComponents<T>(List<T> results) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5CB5A0 Offset: 0x5C9BA0 VA: 0x1805CB5A0
	|-Component.GetComponents<object>
	|-Component.GetComponents<CanvasGroup>
	|-Component.GetComponents<Component>
	|-Component.GetComponents<BaseInputModule>
	|-Component.GetComponents<IMaterialModifier>
	|-Component.GetComponents<Mask>
	*/

	// RVA: -1 Offset: -1
	public T[] GetComponents<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A377C0 Offset: 0x1A35DC0 VA: 0x181A377C0
	|-Component.GetComponents<EZSoftBone>
	|-Component.GetComponents<IImageEffect>
	|-Component.GetComponents<ItemMod>
	|-Component.GetComponents<LODComponentParticleSystem>
	|-Component.GetComponents<TerrainExtension>
	|-Component.GetComponents<Component>
	|-Component.GetComponents<BaseInput>
	|-Component.GetComponents<BaseRaycaster>
	|-Component.GetComponents<object>
	*/

	// RVA: 0x1825280 Offset: 0x1823880 VA: 0x181825280
	public bool CompareTag(string tag) { }

	[FreeFunctionAttribute] // RVA: 0xBA000 Offset: 0xB9400 VA: 0x1800BA000
	// RVA: 0x18256A0 Offset: 0x1823CA0 VA: 0x1818256A0
	public void SendMessageUpwards(string methodName, object value, SendMessageOptions options) { }

	// RVA: 0x18257E0 Offset: 0x1823DE0 VA: 0x1818257E0
	public void SendMessage(string methodName, object value) { }

	// RVA: 0x1825840 Offset: 0x1823E40 VA: 0x181825840
	public void SendMessage(string methodName) { }

	[FreeFunctionAttribute] // RVA: 0xBB650 Offset: 0xBAA50 VA: 0x1800BB650
	// RVA: 0x1825770 Offset: 0x1823D70 VA: 0x181825770
	public void SendMessage(string methodName, object value, SendMessageOptions options) { }

	// RVA: 0x1825710 Offset: 0x1823D10 VA: 0x181825710
	public void SendMessage(string methodName, SendMessageOptions options) { }

	[FreeFunctionAttribute] // RVA: 0xBB760 Offset: 0xBAB60 VA: 0x1800BB760
	// RVA: 0x1825210 Offset: 0x1823810 VA: 0x181825210
	public void BroadcastMessage(string methodName, object parameter, SendMessageOptions options) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x18251C0 Offset: 0x18237C0 VA: 0x1818251C0
	public void BroadcastMessage(string methodName) { }

	// RVA: 0x1825160 Offset: 0x1823760 VA: 0x181825160
	public void BroadcastMessage(string methodName, SendMessageOptions options) { }

	// RVA: 0x181FC60 Offset: 0x181E260 VA: 0x18181FC60
	public void .ctor() { }

}

