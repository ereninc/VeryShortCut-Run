using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    private DataManager _dm;
    private int _level;
    [SerializeField] private GameObject[] grounds;
    [SerializeField] private GameObject[] opponents;

    private void Start()
    {
        _dm = DataManager.instance;
        _level = _dm.GetLevel();
        if (_level > 4)
        {
            _level = 0;
        }
        GenerateLevel();
    }

    private void GenerateLevel()
    {
        SpawnMap();
    }

    private void SpawnMap()
    {
        int arrayCount = grounds.Length;
        for (int i = 0; i < arrayCount; i++)
        {
            if (i == _level)
            {
                grounds[i].SetActive(true);
                opponents[i].SetActive(true);
            }
            else
            {
                grounds[i].SetActive(false);
                opponents[i].SetActive(false);
            }
        }
    }
}