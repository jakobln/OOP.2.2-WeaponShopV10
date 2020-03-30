namespace WeaponShopV10
{
    /// <summary>
    /// This class represents a Wand. A Wand is 
    /// considered to be a weapon.
    /// </summary>
    public class Wand : Weapon
    {
        public const int InitialWandMinDamage = 10;
        public const int InitialWandMaxDamage = 30;
        public bool _isEnchanted;

        #region Constructor
        public Wand(string description, bool isEnchanted) 
            : base(description, InitialWandMinDamage, InitialWandMaxDamage)
        {
            _isEnchanted = isEnchanted;
        } 
        #endregion

        protected bool Enchanted
        {
            get { return _isEnchanted; }
            set { _isEnchanted = value; }
        }
    }
}