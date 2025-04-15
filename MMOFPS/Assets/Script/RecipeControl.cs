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


//// �������п��ܵ�������Ч������
//public enum EffectType
//{
//    // ����Ч��
//    Heal,
//    SpeedBoost,
//    DefenseBoost,
//    ManaRegen,

//    // ����Ч��
//    Poison,
//    Slow,
//    DefenseReduction,
//    ManaDrain
//}

//// ҩ����
//public class Herb
//{
//    public string Name { get; set; }
//    public List<EffectType> PositiveEffects { get; set; } = new List<EffectType>();
//    public List<EffectType> NegativeEffects { get; set; } = new List<EffectType>();

//    // ʾ�����캯��
//    public Herb(string name, List<EffectType> positives, List<EffectType> negatives)
//    {
//        Name = name;
//        PositiveEffects = positives;
//        NegativeEffects = negatives;
//    }
//}

//// ҩˮ��
//public class Potion
//{
//    public string Name { get; set; }
//    public Dictionary<EffectType, float> Effects { get; set; } = new Dictionary<EffectType, float>();

//    // ʾ�����캯��
//    public Potion(string name, Dictionary<EffectType, float> effects)
//    {
//        Name = name;
//        Effects = effects;
//    }
//}

//// ʾ��ʹ��
//public class GameSystem
//{
//    public void Initialize()
//    {
//        // ����ҩ��ʵ��
//        Herb brightleaf = new Herb(
//            "Brightleaf",
//            new List<EffectType> { EffectType.Heal, EffectType.ManaRegen },
//            new List<EffectType> { EffectType.ManaDrain }
//        );

//        // ����ҩˮʵ��
//        Potion healthPotion = new Potion(
//            "Health Potion",
//            new Dictionary<EffectType, float>
//            {
//                { EffectType.Heal, 150f },       // ����150������
//                { EffectType.SpeedBoost, 1.5f }, // �ٶ�����50%
//                { EffectType.Poison, 0.2f }     // ����20%�ж�����
//            }
//        );

//        // ����ҩˮʾ��
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
