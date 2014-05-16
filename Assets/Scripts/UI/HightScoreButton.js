#pragma strict
var ScoreNormal : Texture2D;
var ScoreHover : Texture2D;
var sound : AudioClip;

function Start () {

}

function OnMouseEnter () {
	audio.PlayOneShot(sound);
	guiTexture.texture = ScoreNormal;
}
function OnMouseExit()
{	
	audio.PlayOneShot(sound);
	guiTexture.texture = ScoreHover;
}
function OnMouseDown()
{
	audio.PlayOneShot(sound);
	Application.LoadLevel("HightScore");
}