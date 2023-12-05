using UnityEngine;

public class PlayerChipsCreator : MonoBehaviour
{
    public int PlayersCount = 4;                       // ���������� ������� � ����
    public PlayerChip PlayerChipPrefab;                // ������ ����� ������
    public Sprite[] PlayerChipSprites = new Sprite[0]; // ������ �������� ����� ������� �������� 0

    private void Start()
    {
        SpawnPlayersChips(PlayersCount);  // ��� ������� ���� ������ ����� �������
    }

    private void SpawnPlayersChips(int count)
    {
        // ���������� ���������� ������� � �����
        for (int i = 0; i < count && i <= PlayerChipSprites.Length; i++)
        {
            SpawnPlayerChip(PlayerChipSprites[i]); // ������ ����� ������ � ���������� ��������
        }
    }

    private void SpawnPlayerChip(Sprite sprite)
    {
        // ���� ������ �����������
        if (!sprite) return;
         
        PlayerChip newPlayerChip = Instantiate(PlayerChipPrefab, transform.position, transform.rotation); // ������ ����� ����� ������ �� ������� �����

        newPlayerChip.SetSprite(sprite);  // ������������� ������ �����
    }
}