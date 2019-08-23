using Collections;

namespace Namespaces
{
    internal class MyDictionaryChild<TKey, TValue> : MyDictionary<TKey, TValue>
    {
        public MyDictionaryChild() : base()
        {
        }

        public MyDictionaryChild(int size) : base(size)
        {
        }
    }
}
