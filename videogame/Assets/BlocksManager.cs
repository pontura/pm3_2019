using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlocksManager : MonoBehaviour
{
    public GameObject character;
    public float speed = 5;

    public Block block0;
    public Block block1;
    public List<Block> block2;

    int blockWidth = 20;
    int levelID = 0;

    private void Start()
    {
        AddBlock();
        AddBlock();
    }
    void Update()
    {
        Vector3 pos = character.transform.localPosition;
        pos.x += speed * Time.deltaTime;
        character.transform.localPosition = pos;

       

        if (pos.x > ((levelID - 1) * blockWidth) && levelID < (levelID + 1))
            AddBlock();

    }
    void AddBlock()
    {
        if(speed < 10)
            speed++;

        Block block = null;

        if (levelID == 0)
            block = Instantiate(block0);
        else if (levelID < 4)
            block = Instantiate(block1);
        else
        {
            block = Instantiate(block2[Random.Range(0, block2.Count)]);
        }

        block.transform.localPosition = new Vector3(levelID * blockWidth, 0, 0);
        levelID++;
    }
}
