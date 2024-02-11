namespace SkinsTopUp.Core.Enums
{
    public static  class EnumExtensions
    {
        public static T GetRandomEnumValue<T>() where T : Enum => (T)Enum.GetValues(typeof(T)).OfType<Enum>().OrderBy(_ => Guid.NewGuid()).FirstOrDefault();
    }
}
