using jp.illusive_isc.ReFrame.Core;
using UnityEngine;

namespace jp.illusive_isc.ReFrame.IKUSIA.Rurune
{
    /// <summary>るるね (rurune) 用の ReFrame 宣言。</summary>
    [AddComponentMenu("ILLUSORY OVERRIDE/ReFrame/RuruneReFrame")]
    [ReFrameAvatarSignature(
        "rurune",
        FbxGuids = new[] { "bbd1ddc987dc3d646aa8d77be2cad481" },
        AvatarNames = new[] { "ruruneAvatar" }
    )]
    [ReFrameTheme("Packages/jp.illusive-isc.reframe-rurune/Editor/UI/RuruneTheme.uss")]
    [ReFramePhysBoneGroup("前髪", "Head.002", "Front_hair2_root", "side_1_root")]
    [ReFramePhysBoneGroup("横髪", "sidehair", "side_3_root", "Side_root")]
    [ReFramePhysBoneGroup("後ろ髪", "backhair", "back_side_root")]
    [ReFramePhysBoneGroup("スカート", "Skirt_Root")]
    [ReFramePhysBoneGroup("胸", "Breast")]
    [ReFramePhysBoneGroup("尻尾", "tail.")]
    [ReFramePhysBoneGroup("ヘッドホン", "headphone_particle")]
    [ReFramePhysBoneGroup("撮影の視線", "LookOBJ")]
    [ReFramePhysBoneGroup("ペット", "GrabPysbone")]
    [ReFrameGroupOrder(

        "closet", "Gimmick", "Particle", "Jump&Dash", "IKUSIA_emote",

        "head etc", "cloth",

        "Light_Gun", "Face", "Pet", "Picture",

        "Pen"
    )]
    [ReFrameGroupLabel("closet", "衣装・髪")]
    [ReFrameGroupLabel("head etc", "髪・ヘッドホン")]
    [ReFrameGroupLabel("cloth", "服")]
    [ReFrameGroupLabel("Light_Gun", "ライトガン (蝶)")]
    [ReFrameGroupLabel("Picture", "撮影")]
    [ReFrameGroupLabel("Pet", "ペット (サメ)")]
    [ReFrameGroupLabel("Particle", "パーティクル")]
    [ReFrameGroupLabel("Jump&Dash", "ジャンプ・ダッシュ")]
    [ReFrameQuestCutTransparent("Body", 0)]
    [ReFrameQuestCutTransparent("Body", 1)]
    [ReFrameQuestDropMaterial("acce", 2)]
    [ReFrameQuestBake(Brightness = 0.97f, ShadowFromNormalMap = true, MaxTextureSize = 1024)]
    public class RuruneReFrame : IKUSIACommonReFrame
    {

        [ReFrameDelete("Object1", ReFrameParameterType.Bool)]
        public ReFrameDeleteEntry frontHair1 = new() { Enabled = false, Value = 0f };

        [ReFrameDelete("Object7", ReFrameParameterType.Bool)]
        public ReFrameDeleteEntry pattunShort = new() { Enabled = false, Value = 0f };

        [ReFrameDelete("Object2", ReFrameParameterType.Bool)]
        public ReFrameDeleteEntry sideHair1 = new() { Enabled = false, Value = 1f };

        [ReFrameDelete("Object5", ReFrameParameterType.Bool)]
        public ReFrameDeleteEntry sideHair2 = new() { Enabled = false, Value = 1f };

        [ReFrameDelete("Object3", ReFrameParameterType.Bool)]
        public ReFrameDeleteEntry frontSideL = new() { Enabled = false, Value = 1f };

        [ReFrameDelete("Object6", ReFrameParameterType.Bool)]
        public ReFrameDeleteEntry hair2 = new() { Enabled = false, Value = 1f };

        [ReFrameDelete("Object4", ReFrameParameterType.Bool)]
        public ReFrameDeleteEntry headphone = new() { Enabled = false, Value = 0f };

        [ReFrameMenuGroup("closet", "head etc")]
        [ReFrameLabel("髪留め (back_ribbon)")]
        [ReFrameBlendShape("hair", "back_ribbon")]
        public ReFrameDeleteEntry hairRibbon = new() { Enabled = false, Value = 0f };

        [ReFrameMenuGroup("closet", "head etc")]
        [ReFrameLabel("髪の地面判定")]
        [ReFrameValueLocked(0f)]
        [ReFrameDeleteRelatedBlendTree("Hair_Ground")]
        [ReFrameDeleteObject("Advanced/Hair_Ground")]
        [ReFrameDeleteObject("Advanced/Hair_Contact")]
        public ReFrameDeleteEntry hairGround = new() { Enabled = false, Value = 0f };

        [ReFrameMenuGroup("closet", "head etc")]
        [ReFrameLabel("髪本体 (メッシュごと消す)")]
        [ReFrameValueLocked(0f)]
        [ReFrameDeleteObject("hair")]
        public ReFrameDeleteEntry hairMesh = new() { Enabled = false, Value = 0f };

        [ReFrameDelete("jacket", ReFrameParameterType.Bool)]
        public ReFrameDeleteEntry jacket = new() { Enabled = false, Value = 1f };

        [ReFrameDelete("Cloth", ReFrameParameterType.Bool)]
        public ReFrameDeleteEntry cloth = new() { Enabled = false, Value = 1f };

        [ReFrameDelete("accesary", ReFrameParameterType.Bool)]
        public ReFrameDeleteEntry accessory = new() { Enabled = false, Value = 1f };

        [ReFrameDelete("string", ReFrameParameterType.Bool)]
        public ReFrameDeleteEntry underwearString = new() { Enabled = false, Value = 1f };

        [ReFrameDelete("Glove", ReFrameParameterType.Bool)]
        public ReFrameDeleteEntry glove = new() { Enabled = false, Value = 1f };

        [ReFrameDelete("socks", ReFrameParameterType.Bool)]
        public ReFrameDeleteEntry socks = new() { Enabled = false, Value = 1f };

        [ReFrameDelete("boots", ReFrameParameterType.Bool)]
        public ReFrameDeleteEntry boots = new() { Enabled = false, Value = 1f };

        [ReFrameMenuGroup("closet", "cloth")]
        [ReFrameLabel("下着 (メッシュごと消す)")]
        [ReFrameValueLocked(0f)]
        [ReFrameDeleteObject("underwear")]
        public ReFrameDeleteEntry underwear = new() { Enabled = false, Value = 0f };

        [ReFrameMenuGroup("closet", "cloth")]
        [ReFrameApplyToAvatar]
        [ReFrameLabel("足: ヒールオフ")]
        [ReFrameBlendShape("Body_b", "Foot_heel_OFF_____足_ヒールオフ")]
        [ReFrameBlendShape("knee-socks", "ヒールOFF")]
        public ReFrameDeleteEntry heelOff = new() { Enabled = false, Value = 0f };

        [ReFrameMenuGroup("closet", "cloth")]
        [ReFrameApplyToAvatar]
        [ReFrameLabel("足: ハイヒール")]
        [ReFrameBlendShape("Body_b", "Foot_Hiheel_____足_ハイヒール")]
        [ReFrameBlendShape("knee-socks", "ハイヒール")]
        public ReFrameDeleteEntry highHeel = new() { Enabled = false, Value = 0f };

        [ReFrameMenuGroup("Gimmick")]
        [ReFrameApplyToAvatar]
        [ReFrameLabel("胸: 瑞希100")]
        [ReFrameBlendShape("Body_b", "Breast_Big_____胸_大(mizuki)")]
        [ReFrameBlendShape("underwear", "Breast_Big_____胸_大")]
        [ReFrameBlendShape("acce", "Breast_big(limit)", Scale = 2f)]
        [ReFrameBlendShape("cloth", "Breast_big(limit)", Scale = 2.02f)]
        [ReFrameBlendShape("jacket", "Breast_big(limit)", Scale = 2f)]
        public ReFrameDeleteEntry breastMizuki = new() { Enabled = false, Value = 0f };

        [ReFrameLabel("AllOff (まとめ脱ぎ)")]
        [ReFrameValueLocked(0f)]
        [ReFrameDelete("AllOff", ReFrameParameterType.Float)]
        public ReFrameDeleteEntry allOff = new() { Enabled = true, Value = 0f };

        [ReFrameDelete("LightGun", ReFrameParameterType.Bool)]
        [ReFrameDelete("butterfly_Set", ReFrameParameterType.Bool)]
        [ReFrameDelete("butterfly_Shot", ReFrameParameterType.Bool)]
        [ReFrameDelete("butterfly_Gesture_Set", ReFrameParameterType.Bool)]
        [ReFrameDelete("butterfly_FingerIndexL", ReFrameParameterType.Bool)]
        [ReFrameDelete("butterfly_stand", ReFrameParameterType.Float)]
        [ReFrameValueLocked(0f)]
        [ReFrameDeleteLayer("butterfly", 0f)]
        [ReFrameDeleteObject("Advanced/butterfly", 0f)]
        [ReFrameSetMaxParticles("Advanced/butterfly/world/target_constraint/cyou/idolParticle", 20, Always = true)]
        [ReFrameSetMaxParticles("Advanced/butterfly/world/target_constraint/cyou/idolParticle/idolParticle2", 20, Always = true)]
        [ReFrameSetMaxParticles("Advanced/butterfly/world/target_constraint/cyou/idolParticle/idolParticle2/idolParticle3", 20, Always = true)]
        [ReFrameSetMaxParticles("Advanced/butterfly/world/target_constraint/deru", 20, Always = true)]
        [ReFrameSetMaxParticles("Advanced/butterfly/world/target_constraint/orbit", 20, Always = true)]
        [ReFrameSetMaxParticles("Advanced/butterfly/world/target_constraint/kabecollision", 1, Always = true)]
        [ReFrameSetMaxParticles("Advanced/butterfly/IndexHandR/handtap_ONOFF/handtap", 10, Always = true)]
        [ReFrameQuestParticleMaterial("Advanced/butterfly", Recursive = true)]
        public ReFrameDeleteEntry lightGun = new() { Enabled = false, Value = 0f };

        [ReFrameDelete("LightStrength", ReFrameParameterType.Float)]
        public ReFrameDeleteEntry lightStrength = new() { Enabled = false, Value = 0.3f };

        [ReFrameDelete("TPS", ReFrameParameterType.Bool)]
        [ReFrameUnsyncParameter("TPS")]
        [ReFrameDeleteObject("Advanced/TPS", 0f)]
        public ReFrameDeleteEntry tps = new() { Enabled = false, Value = 0f };

        [ReFrameDelete("clairvoyance", ReFrameParameterType.Bool)]
        [ReFrameUnsyncParameter("clairvoyance")]
        [ReFrameDeleteObject("Advanced/clairvoyance", 0f)]
        public ReFrameDeleteEntry clairvoyance = new() { Enabled = false, Value = 0f };

        [ReFrameQuestForceDelete(Reason = "Contact 22 個で Quest の上限 16 を超える")]
        [ReFrameDelete("Pet_ON", ReFrameParameterType.Bool)]
        [ReFrameDelete("Pet_Head_Position", ReFrameParameterType.Bool)]
        [ReFrameDelete("Pet_Sleep", ReFrameParameterType.Bool)]
        [ReFrameDelete("Pet_Head_Stay", ReFrameParameterType.Bool)]
        [ReFrameDelete("Pet_Hand_hit", ReFrameParameterType.Bool)]
        [ReFrameDelete("Head_search_off", ReFrameParameterType.Bool)]
        [ReFrameDelete("Pet_RandomPosition_off", ReFrameParameterType.Bool)]
        [ReFrameDelete("Pet_position.X", ReFrameParameterType.Float)]
        [ReFrameDelete("Pet_position.Y", ReFrameParameterType.Float)]
        [ReFrameDelete("Pet_position.Z", ReFrameParameterType.Float)]
        [ReFrameValueLocked(0f)]
        [ReFrameDeleteLayer("Pet", 0f)]
        [ReFrameDeleteLayer("Pet_Animation", 0f)]
        [ReFrameDeleteLayer("Pet_Sleep", 0f)]
        [ReFrameDeleteRelatedBlendTree("Pet_Player_Position", 0f)]
        [ReFrameDeleteObject("Advanced/Pet model", 0f)]
        [ReFrameDeleteObject("Advanced/Pet_Player_Position", 0f)]
        [ReFrameDeleteObject("Advanced/Pet_follow", 0f)]
        [ReFrameDeleteObject("Advanced/PlayerDistance_Pet", 0f)]
        [ReFrameSetMaxParticles("Advanced/Pet model/Constraint/Constraint/shark/bubbles_Idol", 10, Always = true)]
        [ReFrameSetMaxParticles("Advanced/Pet model/Constraint/Constraint/zzz", 1, Always = true)]
        [ReFrameSetMaxParticles("Advanced/Pet model/Constraint/Constraint/zzz/zzz2", 3, Always = true)]
        [ReFrameSetMaxParticles("Advanced/Pet model/Constraint/Constraint/zzz/zzz2/zzz3", 3, Always = true)]
        [ReFrameQuestParticleMaterial("Advanced/Pet model", Recursive = true)]
        public ReFrameDeleteEntry pet = new() { Enabled = false, Value = 0f };

        [ReFrameDelete("LightCamera", ReFrameParameterType.Bool)]
        [ReFrameDelete("LookOBJ", ReFrameParameterType.Bool)]
        [ReFrameDelete("Camera_eye_hide", ReFrameParameterType.Bool)]
        [ReFrameDelete("eyeLook", ReFrameParameterType.Float)]
        [ReFrameValueLocked(0f)]
        [ReFrameDeleteObject("Advanced/LookOBJHead", 0f)]
        [ReFrameDeleteObject("Advanced/CametaLightOBJ_World", 0f)]
        [ReFrameQuestParticleMaterial("Advanced/LookOBJHead", Recursive = true)]
        [ReFrameQuestParticleMaterial("Advanced/CametaLightOBJ_World", Recursive = true)]
        public ReFrameDeleteEntry picture = new() { Enabled = false, Value = 0f };

        [ReFrameMenuGroup("Gimmick", "Face")]
        [ReFrameLabel("表情プリセット")]
        [ReFrameValueLocked(0f)]
        [ReFrameDeleteLayer("LeftHand", 0f)]
        [ReFrameDeleteLayer("RightHand", 0f)]
        public ReFrameDeleteEntry faceGesturePreset = new() { Enabled = false, Value = 0f };

        [ReFrameLabel("エモートメニューを外す")]
        [ReFrameValueLocked(0f)]
        [ReFrameMenuRemove("IKUSIA_emote", Keep = new[] { "姿勢変更/AFK" })]
        public ReFrameDeleteEntry ikusiaEmoteMenu = new() { Enabled = false, Value = 0f };

        [ReFrameDelete("Blink off", ReFrameParameterType.Bool)]
        public ReFrameDeleteEntry blinkOff = new() { Enabled = false, Value = 0f };

        [ReFrameDelete("Particle1", ReFrameParameterType.Bool)]
        [ReFrameDeleteRelatedBlendTree("VoiceParticle1", 0f)]
        [ReFrameDeleteObject("Advanced/Particle/1", 0f)]
        [ReFrameSetMaxParticles("Advanced/Particle/1/breath", 100, Always = true)]
        [ReFrameQuestParticleMaterial("Advanced/Particle/1", Recursive = true)]
        public ReFrameDeleteEntry whiteBreath = new() { Enabled = false, Value = 0f };

        [ReFrameDelete("Particle3", ReFrameParameterType.Bool)]
        [ReFrameDeleteRelatedBlendTree("Voice_bubbles", 0f)]
        [ReFrameDeleteObject("Advanced/Particle/3", 0f)]
        [ReFrameSetMaxParticles("Advanced/Particle/3/Headbubbles/bubbles", 50, Always = true)]
        [ReFrameSetMaxParticles("Advanced/Particle/3/Headbubbles/bubbles/bubbles2", 50, Always = true)]
        [ReFrameSetMaxParticles("Advanced/Particle/3/Headbubbles/bubbles_Idol", 50, Always = true)]
        [ReFrameSetMaxParticles("Advanced/Particle/3/Headbubbles/bubbles_Idol/bubbles2", 50, Always = true)]
        [ReFrameQuestParticleMaterial("Advanced/Particle/3", Recursive = true)]
        public ReFrameDeleteEntry bubbleBreath = new() { Enabled = false, Value = 0f };

        [ReFrameDelete("Particle2", ReFrameParameterType.Bool)]
        [ReFrameDeleteRelatedBlendTree("WaterFoot_R", 0f)]
        [ReFrameDeleteRelatedBlendTree("WaterFoot_L", 0f)]
        [ReFrameDeleteObject("Advanced/Particle/2", 0f)]
        [ReFrameSetMaxParticles("Advanced/Particle/2/WaterFoot_R/WaterFoot2/WaterFoot3", 10, Always = true)]
        [ReFrameSetMaxParticles("Advanced/Particle/2/WaterFoot_R/WaterFoot2/WaterFoot3/WaterFoot4", 10, Always = true)]
        [ReFrameSetMaxParticles("Advanced/Particle/2/WaterFoot_L/WaterFoot2/WaterFoot3", 10, Always = true)]
        [ReFrameSetMaxParticles("Advanced/Particle/2/WaterFoot_L/WaterFoot2/WaterFoot3/WaterFoot4", 10, Always = true)]
        [ReFrameQuestParticleMaterial("Advanced/Particle/2", Recursive = true)]
        public ReFrameDeleteEntry waterStamp = new() { Enabled = false, Value = 0f };

        [ReFrameDelete("Particle4", ReFrameParameterType.Bool)]
        [ReFrameBundleMember("Object4")]
        [ReFrameDeleteObject("Advanced/Particle/4", 0f)]
        [ReFrameDeleteObject("Armature/Hips/Spine/Chest/Neck/Head/headphone_particle", 0f)]
        [ReFrameQuestParticleMaterial("Advanced/Particle/4", Recursive = true)]
        public ReFrameDeleteEntry headphoneParticle = new() { Enabled = false, Value = 0f };

        [ReFrameDelete("Particle5", ReFrameParameterType.Bool)]
        [ReFrameDeleteObject("Advanced/Particle/5", 0f)]
        [ReFrameSetMaxParticles("Advanced/Particle/5/8bitheart", 5, Always = true)]
        [ReFrameSetMaxParticles("Advanced/Particle/5/8bitheart/8bitheart flare", 15, Always = true)]
        [ReFrameQuestParticleMaterial("Advanced/Particle/5", Recursive = true)]
        public ReFrameDeleteEntry eightBit = new() { Enabled = false, Value = 0f };

        [ReFrameDelete("PenColor", ReFrameParameterType.Bool)]
        [ReFrameDelete("Pen1", ReFrameParameterType.Bool)]
        [ReFrameDelete("Pen1Grab", ReFrameParameterType.Bool)]
        [ReFrameDelete("Pen2", ReFrameParameterType.Bool)]
        [ReFrameDelete("Pen2Grab", ReFrameParameterType.Bool)]
        [ReFrameValueLocked(0f)]
        [ReFrameDeleteState("PenCtrl_R", "particlePen1draw R", 0f)]
        [ReFrameDeleteState("PenCtrl_R", "particlePen1draw off R", 0f)]
        [ReFrameDeleteState("PenCtrl_R", "particlePenGrabCtrl1 R", 0f)]
        [ReFrameDeleteState("PenCtrl_R", "PenEraserR", 0f)]
        [ReFrameDeleteState("PenCtrl_L", "particlePen1draw L", 0f)]
        [ReFrameDeleteState("PenCtrl_L", "particlePen1draw off L", 0f)]
        [ReFrameDeleteState("PenCtrl_L", "particlePenGrabCtrl1 L", 0f)]
        [ReFrameDeleteState("PenCtrl_L", "PenEraserL", 0f)]
        [ReFrameDeleteObject("Advanced/Particle/7", 0f)]
        [ReFrameDeleteObject("Advanced/Constraint/Index_R_Constraint", 0f)]
        [ReFrameDeleteObject("Advanced/Constraint/Index_L_Constraint", 0f)]
        [ReFrameDeleteObject("Advanced/Constraint/Hand_R_Constraint0", RequiresAll = new[] { "HeartGun" })]
        [ReFrameDeleteObject("Advanced/Constraint/Hand_L_Constraint0", RequiresAll = new[] { "HeartGun" })]
        [ReFrameSetMaxParticles("Advanced/Particle/7/2/pen1_R/PenParticle", 10000, Always = true)]
        [ReFrameSetMaxParticles("Advanced/Particle/7/2/pen1_R/PenParticle/SubEmitter0", 5000, Always = true)]
        [ReFrameSetMaxParticles("Advanced/Particle/7/4/pen1_L/PenParticle", 10000, Always = true)]
        [ReFrameSetMaxParticles("Advanced/Particle/7/4/pen1_L/PenParticle/SubEmitter0", 5000, Always = true)]
        [ReFrameQuestParticleMaterial("Advanced/Particle/7", Recursive = true)]
        public ReFrameDeleteEntry pen = new() { Enabled = false, Value = 0f };

        [ReFrameDelete("HeartGun", ReFrameParameterType.Bool)]
        [ReFrameDelete("HeartGunCollider R", ReFrameParameterType.Float)]
        [ReFrameDelete("HeartGunCollider L", ReFrameParameterType.Float)]
        [ReFrameValueLocked(0f)]
        [ReFrameDeleteLayer("HeartGun", 0f)]
        [ReFrameDeleteObject("Advanced/HeartGunR", 0f)]
        [ReFrameDeleteObject("Advanced/HeartGunL", 0f)]
        [ReFrameDeleteObject("Advanced/HeartGunR2", 0f)]
        [ReFrameDeleteObject("Advanced/HeartGunL2", 0f)]
        [ReFrameDeleteObject("Advanced/Constraint/Hand_R_Constraint0", RequiresAll = new[] { "Pen1" })]
        [ReFrameDeleteObject("Advanced/Constraint/Hand_L_Constraint0", RequiresAll = new[] { "Pen1" })]
        [ReFrameSetMaxParticles("Advanced/HeartGunR/HeartGunFLY/HeartGunFLY2", 50, Always = true)]
        [ReFrameSetMaxParticles("Advanced/HeartGunR/HeartGunFLY/HeartGunFLY2/kira", 3200, Always = true)]
        [ReFrameSetMaxParticles("Advanced/HeartGunR/HeartGunFLY/HeartGunFLY2/Heart", 100, Always = true)]
        [ReFrameSetMaxParticles("Advanced/HeartGunR/HeartGunFLY/HeartGunFLY2/shot2", 400, Always = true)]
        [ReFrameSetMaxParticles("Advanced/HeartGunR/HeartGunFLY/HeartGunFLY2/shot2 (1)", 400, Always = true)]
        [ReFrameSetMaxParticles("Advanced/HeartGunR/HeartGunFLY/HeartGunChargeStay", 50, Always = true)]
        [ReFrameSetMaxParticles("Advanced/HeartGunR/HeartGunCollider/HeadHit/HeadHit", 50, Always = true)]
        [ReFrameSetMaxParticles("Advanced/HeartGunR/HeartGunCollider/HeadHit/Heart (1)", 50, Always = true)]
        [ReFrameSetMaxParticles("Advanced/HeartGunL/HeartGunFLY/HeartGunFLY2", 50, Always = true)]
        [ReFrameSetMaxParticles("Advanced/HeartGunL/HeartGunFLY/HeartGunFLY2/kira", 3200, Always = true)]
        [ReFrameSetMaxParticles("Advanced/HeartGunL/HeartGunFLY/HeartGunFLY2/Heart", 100, Always = true)]
        [ReFrameSetMaxParticles("Advanced/HeartGunL/HeartGunFLY/HeartGunFLY2/shot2", 400, Always = true)]
        [ReFrameSetMaxParticles("Advanced/HeartGunL/HeartGunFLY/HeartGunFLY2/shot2 (1)", 400, Always = true)]
        [ReFrameSetMaxParticles("Advanced/HeartGunL/HeartGunFLY/HeartGunChargeStay", 50, Always = true)]
        [ReFrameSetMaxParticles("Advanced/HeartGunL/HeartGunCollider/HeadHit/HeadHit", 50, Always = true)]
        [ReFrameSetMaxParticles("Advanced/HeartGunL/HeartGunCollider/HeadHit/Heart (1)", 50, Always = true)]
        [ReFrameSetMaxParticles("Advanced/HeartGunR2/HeartGunFLY/HeartGunFLY2", 50, Always = true)]
        [ReFrameSetMaxParticles("Advanced/HeartGunR2/HeartGunFLY/HeartGunFLY2/kira", 3200, Always = true)]
        [ReFrameSetMaxParticles("Advanced/HeartGunR2/HeartGunFLY/HeartGunFLY2/Heart", 100, Always = true)]
        [ReFrameSetMaxParticles("Advanced/HeartGunR2/HeartGunFLY/HeartGunFLY2/shot2", 400, Always = true)]
        [ReFrameSetMaxParticles("Advanced/HeartGunR2/HeartGunFLY/HeartGunFLY2/shot2 (1)", 400, Always = true)]
        [ReFrameSetMaxParticles("Advanced/HeartGunR2/HeartGunFLY/HeartGunChargeStay", 50, Always = true)]
        [ReFrameSetMaxParticles("Advanced/HeartGunL2/HeartGunFLY/HeartGunFLY2", 50, Always = true)]
        [ReFrameSetMaxParticles("Advanced/HeartGunL2/HeartGunFLY/HeartGunFLY2/kira", 3200, Always = true)]
        [ReFrameSetMaxParticles("Advanced/HeartGunL2/HeartGunFLY/HeartGunFLY2/Heart", 100, Always = true)]
        [ReFrameSetMaxParticles("Advanced/HeartGunL2/HeartGunFLY/HeartGunFLY2/shot2", 1200, Always = true)]
        [ReFrameSetMaxParticles("Advanced/HeartGunL2/HeartGunFLY/HeartGunFLY2/shot2 (1)", 1200, Always = true)]
        [ReFrameSetMaxParticles("Advanced/HeartGunL2/HeartGunFLY/HeartGunChargeStay", 50, Always = true)]
        [ReFrameQuestParticleMaterial("Advanced/HeartGunR", Recursive = true)]
        [ReFrameQuestParticleMaterial("Advanced/HeartGunL", Recursive = true)]
        [ReFrameQuestParticleMaterial("Advanced/HeartGunR2", Recursive = true)]
        [ReFrameQuestParticleMaterial("Advanced/HeartGunL2", Recursive = true)]
        public ReFrameDeleteEntry heartGun = new() { Enabled = false, Value = 0f };

        [ReFrameMenuGroup("Particle")]
        [ReFrameLabel("AFK の水辺演出 (間引き)")]
        [ReFrameValueLocked(0f)]
        [ReFrameDeleteObject("Advanced/AFK_World/position/water2")]
        [ReFrameDeleteObject("Advanced/AFK_World/position/water3")]
        [ReFrameDeleteObject("Advanced/AFK_World/position/AFKIN Particle")]
        [ReFrameDeleteObject("Advanced/AFK_World/position/swim")]
        [ReFrameDeleteObject("Advanced/AFK_World/position/IdolParticle")]
        [ReFrameSetMaxParticles("Advanced/AFK_World/position/swim/Particle System", 10, Always = true)]
        [ReFrameSetMaxParticles("Advanced/AFK_World/position/IdolParticle", 1, Always = true)]
        [ReFrameSetMaxParticles("Advanced/AFK_World/position/AFKIN Particle/AFK In0", 1, Always = true)]
        [ReFrameSetMaxParticles("Advanced/AFK_World/position/AFKIN Particle/AFK In1", 1, Always = true)]
        [ReFrameSetMaxParticles("Advanced/AFK_World/position/AFKIN Particle/AFK In1/IN S1", 1, Always = true)]
        [ReFrameSetMaxParticles("Advanced/AFK_World/position/AFKIN Particle/AFK In2", 20, Always = true)]
        [ReFrameSetMaxParticles("Advanced/AFK_World/position/AFKIN Particle/AFK In2/AFK In (1)", 20, Always = true)]
        [ReFrameSetMaxParticles("Advanced/AFK_World/position/AFKIN Particle/IN S3", 1, Always = true)]
        [ReFrameSetMaxParticles("Advanced/AFK_World/position/AFKIN Particle/IN S3/AFK In (1)", 1, Always = true)]
        [ReFrameQuestParticleMaterial("Advanced/AFK_World", Recursive = true)]
        public ReFrameDeleteEntry afkWater = new() { Enabled = false, Value = 0f };

        [ReFrameDelete("JumpCollider", ReFrameParameterType.Bool)]
        [ReFrameDelete("Paryi_KeyJump", ReFrameParameterType.Bool)]
        [ReFrameDelete("SpeedCollider", ReFrameParameterType.Bool)]
        [ReFrameDelete("Paryi_KeySpeed", ReFrameParameterType.Bool)]
        [ReFrameDelete("ColliderON", ReFrameParameterType.Bool)]
        [ReFrameCutUndrivenTransitions("Paryi_KeyJump", EvaluateAsFixed = true)]
        [ReFrameCutUndrivenTransitions("Paryi_KeySpeed", EvaluateAsFixed = true)]
        [ReFrameUnsyncParameter("JumpCollider")]
        [ReFrameUnsyncParameter("SpeedCollider")]
        [ReFrameUnsyncParameter("ColliderON")]
        [ReFrameValueLocked]
        [ReFrameDeleteObject("Advanced/Gimmick1/JUMP")]
        [ReFrameDeleteObject("Advanced/Gimmick1/SPEED")]
        public ReFrameDeleteEntry jumpDashCollider = new() { Enabled = false, Value = 0f };

        [ReFrameMenuGroup("closet")]
        [ReFrameLabel("尻尾の地面判定")]
        [ReFrameValueLocked(0f)]
        [ReFrameDeleteRelatedBlendTree("tail_Ground")]
        [ReFrameDeleteObject("Advanced/sippo_contact")]
        [ReFrameDeleteObject("Advanced/tail_Ground")]
        public ReFrameDeleteEntry tailGround = new() { Enabled = false, Value = 0f };

        [ReFrameMenuGroup("closet")]
        [ReFrameLabel("尻尾 (メッシュごと消す)")]
        [ReFrameValueLocked(0f)]
        [ReFrameDeleteObject("sharktail")]
        [ReFrameDeleteObject("tail_ribbon")]
        [ReFrameDeleteObject("Advanced/sippo_contact")]
        [ReFrameDeleteObject("Advanced/tail_Ground")]
        public ReFrameDeleteEntry tail = new() { Enabled = false, Value = 0f };

        [ReFrameMenuGroup("closet")]
        [ReFrameLabel("尻尾のリボン")]
        [ReFrameValueLocked(0f)]
        [ReFrameDeleteObject("tail_ribbon")]
        public ReFrameDeleteEntry tailRibbon = new() { Enabled = false, Value = 0f };

        [ReFrameLabel("未使用の置き物 (常に削除)")]
        [ReFrameValueLocked(0f)]
        [ReFrameDeleteObject("Advanced/Object", Always = true)]
        [ReFrameDeleteObject("Advanced/FaceEffect", Always = true)]
        [ReFrameDeleteObject("Advanced/Particle/6", Always = true)]
        [ReFrameDeleteObject("Advanced/Gimmick1/8", Always = true)]
        [ReFrameDeleteObject("Advanced/Gimmick2/3", Always = true)]
        [ReFrameDeleteObject("Advanced/Gimmick2/5", Always = true)]
        [ReFrameDeleteObject("Advanced/Gimmick2/6", Always = true)]
        [ReFrameDeleteObject("Advanced/Gimmick2/7", Always = true)]
        [ReFrameDeleteObject("Advanced/cameraLight&eyeLookHide", Always = true)]
        [ReFrameCutUndrivenTransitions("Gimmick2_6", EvaluateAsFixed = true)]
        [ReFrameUnsyncParameter("takasa")]
        [ReFrameUnsyncParameter("takasa_Toggle")]
        [ReFrameUnsyncParameter("Action_Mode_Reset")]
        [ReFrameUnsyncParameter("Action_Mode")]
        [ReFrameUnsyncParameter("Mirror")]
        [ReFrameUnsyncParameter("Mirror Toggle")]
        [ReFrameUnsyncParameter("paryi_change_all_reset")]
        [ReFrameUnsyncParameter("paryi_change_Mirror_S")]
        [ReFrameUnsyncParameter("paryi_change_Mirror_P")]
        [ReFrameUnsyncParameter("paryi_change_Mirror_H")]
        [ReFrameUnsyncParameter("paryi_change_Mirror_C")]
        [ReFrameUnsyncParameter("paryi_chang_Loco")]
        [ReFrameUnsyncParameter("paryi_Jump")]
        [ReFrameUnsyncParameter("paryi_Jump_cancel")]
        [ReFrameUnsyncParameter("paryi_change_Standing_M")]
        [ReFrameUnsyncParameter("paryi_change_Crouching_M")]
        [ReFrameUnsyncParameter("paryi_change_Prone_M")]
        [ReFrameUnsyncParameter("paryi_floating_M")]
        [ReFrameUnsyncParameter("leg fixed")]
        public ReFrameDeleteEntry leftovers = new() { Enabled = true, Value = 0f };
    }
}
