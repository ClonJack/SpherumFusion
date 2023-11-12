using UnityEngine;

namespace UtilsSpherum
{
	public class HumanoidAvatarBuilder : MonoBehaviour
	{
		private Animator _animator;

		public void Awake()
		{
			_animator = GetComponent<Animator>();
			
			var description = AvatarBuilderUtils.CreateHumanDescription(gameObject);
			
			var avatar = AvatarBuilder.BuildHumanAvatar(gameObject, description);
			
			avatar.name = gameObject.name;
			
			_animator.avatar = avatar;
		}
	}
}