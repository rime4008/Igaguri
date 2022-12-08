using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgaguriController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        Shoot(new Vector3(0, 200, 2000));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// �����Ŏw�肵�������֗͂�������
    /// </summary>
    /// <param name="dir"></param>
    public void Shoot(Vector3 dir)
    {
        GetComponent<Rigidbody>().AddForce(dir);
    }

    /// <summary>
    /// �C�K�O���Փˎ��̏���
    /// </summary>
    /// <param name="collision"></param>
    private void OnCollisionEnter(Collision collision)
    {
        // �C�K�O���̓������~����
        GetComponent<Rigidbody>().isKinematic = true;

        // �C�K�O���̃p�[�e�B�J���G�t�F�N�g�J�n
        GetComponent<ParticleSystem>().Play();

    }
}
