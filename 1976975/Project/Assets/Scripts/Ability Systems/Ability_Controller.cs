using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

/// <summary>Controls what ability is currently selected, if it has enough mana to fire and controls the actual ability firing via Switch statements.</summary>
[RequireComponent(typeof(CharacterController))]
public class Ability_Controller : MonoBehaviour
{
    public float mana;
    public float MP5;
    public TextMeshProUGUI manaText;
    public TextMeshProUGUI abilityText;
    public Ability_Info[] playerAbilities;
    public Abilities abilities;

    private int currentSpell;
    private float currentMana;

    /// <summary>Starts this instance.</summary>
    /// <remarks>Sets internal mana value to the one selected publicly. Initialises text as well</remarks>
    /// <example>
    ///   <code>private void Start()
    /// {
    ///     currentMana = mana;
    ///
    ///     manaText.text = string.Format("Mana: {0}", mana);
    ///     abilityText.text = string.Format("Ability: {0}", playerAbilities[currentSpell].name);
    /// }</code>
    /// </example>
    private void Start()
    {
        currentMana = mana;

        manaText.text = string.Format("Mana: {0}", mana);
        abilityText.text = string.Format("Ability: {0}", playerAbilities[currentSpell].name);
    }

    /// <summary>Updates this instance.</summary>
    /// <remarks>ManaRegen is called to constantly regen mana. Checks if abilities are switched and checks if RMB is pressed to fire said ability</remarks>
    /// <example>
    ///   <code>void Update()
    /// {
    ///     currentSpell = Mathf.Clamp(currentSpell, 0, playerAbilities.Length - 1);
    ///
    ///     ManaRegen(MP5);
    ///
    ///     if (Input.GetKeyDown("q"))
    ///     {
    ///         currentSpell--;
    ///         abilityText.text = string.Format("Ability: {0}", playerAbilities[currentSpell].name);
    ///     }
    ///     else if (Input.GetKeyDown("e"))
    ///     {
    ///         currentSpell++;
    ///         abilityText.text = string.Format("Ability: {0}", playerAbilities[currentSpell].name);
    ///     }
    ///
    ///     if (Input.GetMouseButtonDown(1))
    ///     {
    ///         UseSpell(currentSpell);
    ///     }
    /// }</code>
    /// </example>
    void Update()
    {
        currentSpell = Mathf.Clamp(currentSpell, 0, playerAbilities.Length - 1);

        ManaRegen(MP5);

        if (Input.GetKeyDown("q"))
        {
            currentSpell--;
            abilityText.text = string.Format("Ability: {0}", playerAbilities[currentSpell].name);
        }
        else if (Input.GetKeyDown("e"))
        {
            currentSpell++;
            abilityText.text = string.Format("Ability: {0}", playerAbilities[currentSpell].name);
        }

        if (Input.GetMouseButtonDown(1))
        {
            UseSpell(currentSpell);
        }
    }

    /// <summary>Uses the specified spell.</summary>
    /// <param name="spellId">The Spell id to fire</param>
    /// <remarks>Checks if you have enough mana. Then takes the supplied spellId and passes it through the switch statement where it fires the corresponding ability</remarks>
    /// <example>
    ///   <code>void UseSpell(int spellId) 
    /// {
    ///     if (currentMana &gt;= playerAbilities[spellId].manaCost)
    ///     {
    ///         currentMana -= playerAbilities[spellId].manaCost;
    ///         manaText.text = string.Format("Mana: {0}", currentMana.ToString("F0"));
    ///
    ///         switch (spellId)
    ///         {
    ///             case 0:
    ///                 abilities.LightningStrike();
    ///                 break;
    ///             case 1:
    ///                 abilities.Teleport();
    ///                 break;
    ///         }
    ///     }
    /// }</code>
    /// </example>
    void UseSpell(int spellId) 
    {
        if (currentMana >= playerAbilities[spellId].manaCost)
        {
            currentMana -= playerAbilities[spellId].manaCost;
            manaText.text = string.Format("Mana: {0}", currentMana.ToString("F0"));

            switch (spellId)
            {
                case 0:
                    abilities.LightningStrike();
                    break;
                case 1:
                    abilities.Teleport();
                    break;
            }
        }
    }

    private float timer;
    /// <summary>Regens mana every second.</summary>
    /// <param name="manaToAdd">The mana to add.</param>
    /// <remarks>Adds the supplied mana value every second after dividing it by 5 as the Inspector float supplies MP5(Mana per 5 seconds)</remarks>
    /// <example>
    ///   <code>private float timer;
    /// void ManaRegen(float manaToAdd) 
    /// {
    ///     timer += Time.deltaTime;
    ///     manaToAdd = manaToAdd / 5;
    ///     if (timer &gt;= 1)
    ///     {
    ///         currentMana = Mathf.Clamp(currentMana, 0, mana);
    ///         manaText.text = string.Format("Mana: {0}", currentMana.ToString("F0"));
    ///         currentMana += manaToAdd;
    ///         timer = 0;
    ///     }
    /// }</code>
    /// </example>
    void ManaRegen(float manaToAdd) 
    {
        timer += Time.deltaTime;
        manaToAdd = manaToAdd / 5;
        if (timer >= 1)
        {
            currentMana = Mathf.Clamp(currentMana, 0, mana);
            manaText.text = string.Format("Mana: {0}", currentMana.ToString("F0"));
            currentMana += manaToAdd;
            timer = 0;
        }
    }
}

/// <summary>Stores ability info like mana cost that is then accessed by the ability controller</summary>
[System.Serializable]
public class Ability_Info
{
    public string name;
    public string description;
    public int manaCost;
}
