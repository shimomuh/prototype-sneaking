using PrototypeSneaking.Domain;
using UnityEngine;
using com.amabie.SingletonKit;

namespace PrototypeSneaking.Application.Stage
{
    public interface ICharacterController
    {
        void Attach(ICharacter character);
    }

    public class CharacterController : SingletonMonoBehaviour<CharacterController>, ICharacterController
    {
        ICharacter character;

        public void Attach(ICharacter character)
        {
            this.character = character;
        }

        // TODO: UpdateByFrame にするかは実装次第
        public void Update()
        {
            var horizontal = Input.GetAxis("Horizontal");
            //var vertical = Input.GetAxis("Vertical");
            if (horizontal != 0)
            {
                Debug.Log("input!");
                character.GameObject.transform.Translate(horizontal, 0, 0);
            }
        }
    }
}