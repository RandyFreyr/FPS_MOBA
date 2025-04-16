////using System.Collections;
////using System.Collections.Generic;
////using UnityEngine;

////public class RecipeControl : MonoBehaviour
////{
////    // Start is called before the first frame update
////    void Start()
////    {

////    }

////    // Update is called once per frame
////    void Update()
////    {

////    }
////}


//// 定义所有可能的正负面效果类型
//public enum EffectType
//{
//    // 正面效果
//    Heal,
//    SpeedBoost,
//    DefenseBoost,
//    ManaRegen,

//    // 负面效果
//    Poison,
//    Slow,
//    DefenseReduction,
//    ManaDrain
//}

//// 药材类
//public class Herb
//{
//    public string Name { get; set; }
//    public List<EffectType> PositiveEffects { get; set; } = new List<EffectType>();
//    public List<EffectType> NegativeEffects { get; set; } = new List<EffectType>();

//    // 示例构造函数
//    public Herb(string name, List<EffectType> positives, List<EffectType> negatives)
//    {
//        Name = name;
//        PositiveEffects = positives;
//        NegativeEffects = negatives;
//    }
//}

//// 药水类
//public class Potion
//{
//    public string Name { get; set; }
//    public Dictionary<EffectType, float> Effects { get; set; } = new Dictionary<EffectType, float>();

//    // 示例构造函数
//    public Potion(string name, Dictionary<EffectType, float> effects)
//    {
//        Name = name;
//        Effects = effects;
//    }
//}

//// 示例使用
//public class GameSystem
//{
//    public void Initialize()
//    {
//        // 创建药材实例
//        Herb brightleaf = new Herb(
//            "Brightleaf",
//            new List<EffectType> { EffectType.Heal, EffectType.ManaRegen },
//            new List<EffectType> { EffectType.ManaDrain }
//        );

//        // 创建药水实例
//        Potion healthPotion = new Potion(
//            "Health Potion",
//            new Dictionary<EffectType, float>
//            {
//                { EffectType.Heal, 150f },       // 治疗150点生命
//                { EffectType.SpeedBoost, 1.5f }, // 速度提升50%
//                { EffectType.Poison, 0.2f }     // 附带20%中毒概率
//            }
//        );

//        // 复杂药水示例
//        Potion chaosElixir = new Potion(
//            "Chaos Elixir",
//            new Dictionary<EffectType, float>
//            {
//                { EffectType.DefenseBoost, 2f },
//                { EffectType.ManaRegen, 5f },
//                { EffectType.Slow, 0.7f },
//                { EffectType.ManaDrain, 3f }
//            }
//        );
//    }
//}
