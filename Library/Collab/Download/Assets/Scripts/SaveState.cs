using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public static class SaveState{

    public int[3] levels; 
    
    public static EnemyData LoadEnemy() {
        string path = Application.persistentDataPath + "/enemy.saved";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            EnemyData data = formatter.Deserialize(stream) as EnemyData;
            stream.Close;

            return data;
        }
        else
        {
            Debug.LogError("Save file not found" + path);
            return null;
        }
    }

    public static void SaveEnemies(SlimeMovement slime, Turret turret)
    {

        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/enemy.saved" + "";
        FileStream stream = new FileStream(path, FileMode.Create);

        EnemyData data = new EnemyData(enemy);

        formatter.Serialize(stream, data);
        stream.Close();

    }
}
