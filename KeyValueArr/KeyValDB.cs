using System;

namespace KeyValueArr
{
    public class KeyValDB<K, V>
    {

        private K[] keyArr;
        private V[] valArr;
        private int count;
        public KeyValDB()
        {
            keyArr = new K[5];
            valArr = new V[5];
            count = 0;
        }

        private void initializeArrs()
        {

        }

        public void Add(K key, V val)
        {
            if (count == keyArr.Length)
            {
                Array.Resize(ref keyArr, keyArr.Length * 2);
                Array.Resize(ref valArr, valArr.Length * 2);
            }
            keyArr[count] = key;
            valArr[count] = val;
            count++;
        }

        public bool Remove(K key)
        {
            int index = Array.IndexOf(keyArr, key);
            if (index == -1)
            {
                return false;
            }
            for (int i = 0; i < keyArr.Length - 1; i++)
            {
                keyArr[i] = keyArr[i + 1];
            }

            for (int i = 0; i < valArr.Length - 1; i++)
            {
                valArr[i] = valArr[i + 1];
            }
            count--;
            return true;
        }

        public bool TryGet(K key, out V value)
        {
            value = default;
            int index = Array.IndexOf(keyArr, key);
            if (index == -1)
            {
                return false;
            }
            value = valArr[index];
            return true;
        }

        public void PrintDB()
        {
            for (int i = 0; i < keyArr.Length; i++)
            {
                Console.WriteLine($"{keyArr[i]} : {valArr[i]}");
            }
        }
    }
}
