using UnityEngine;
using UnityEngine.AI;

public class SpawnScript : MonoBehaviour
{
    public GameObject brute;
    private NavMeshAgent agent;
    //private Animator anim;

    Animation anim;

    public int spawnCount = 0;



    // Start is called before the first frame update
    void Start()
    {

        agent = GetComponent<NavMeshAgent>();
        //anim = GetComponent<Animator>();

        //Instantiate(brute, new Vector3(27, 1, 20), Quaternion.identity);
        //Instantiate(brute, new Vector3(27, 1, 18), Quaternion.identity);
        //Instantiate(brute, new Vector3(26, 1, 20), Quaternion.identity);
        //Instantiate(brute, new Vector3(26, 1, 18), Quaternion.identity);

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject bruteAI = Instantiate(brute, new Vector3(26, 2, 19), Quaternion.identity);
            spawnCount++;
            anim = bruteAI.GetComponent<Animation>();
            Debug.Log(spawnCount);
        }

    }


}
