using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ming
{
    public class Weapon : MonoBehaviour
    {
        public int dmg;

        // -1 ���� = �ı��� ����
        private int level;
        public int Level
        {
            get { return level; }
            set
            {
                level = value;
                Debug.Log(level);
            }
        }
        public int destroyedLevel = -1;

        // ���� ���� ��ȭ �ܰ� �ִ�ġ
        public int maxSafeLevel = 20;
        public bool isDestroyed = false;

        public int upCost;
        public int reCost;
        public int upProb;

        void Start()
        {
            Level = 20;
        }

        public void DestroyWeapon()
        {
            // Ȯ�� ó�� ��
            isDestroyed = true;
            destroyedLevel = Level;
            Level = -1;
        }
    }
}

