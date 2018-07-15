using UnityEngine;

// reference: https://answers.unity.com/questions/1123326/jsonutility-array-not-supported.html
public class JSONHelper
{
    public static T[] JSONToArray<T>(string json)
    {
        Wrapper<T> wrapper = JsonUtility.FromJson<Wrapper<T>>(json);
        return wrapper.array;
    }

    public static string ArraryToJSON<T>(T[] array)
    {
        Wrapper<T> wrapper = new Wrapper<T>
        {
            array = array
        };

        return JsonUtility.ToJson(wrapper);
    }

    [System.Serializable]
    private class Wrapper<T>
    {
        public T[] array;
    }
}
