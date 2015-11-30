using UnityEngine;
using System.Collections;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

public class PlayerPrefSerialization : MonoBehaviour {

	public static BinaryFormatter binarryFormatter = new BinaryFormatter();

	public static void Save(string key, object obj) {
		MemoryStream memoryStream = new MemoryStream ();
		binarryFormatter.Serialize (memoryStream, obj);
		string tempResultStream = System.Convert.ToBase64String (memoryStream.ToArray ());
		PlayerPrefs.SetString (key, tempResultStream);
	}

	public static object Load(string key) {
		string tempObjAsBinary = PlayerPrefs.GetString (key);
		if (tempObjAsBinary == string.Empty) {
			return null;
		} else {
			MemoryStream memoryStream = new MemoryStream(System.Convert.FromBase64String(tempObjAsBinary));
			return binarryFormatter.Deserialize(memoryStream);
		}
	}
}
