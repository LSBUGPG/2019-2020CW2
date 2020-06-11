/*
This dust particle generator checks to see if the character's rigidbody velocity is greater than zero.
 If it is, it spawns a dust particle. A dust particle prefab is a particle system that fades out to 
 transparent and deletes itself after a second so that it doesn't affect performance too much.

 The dust prefab must be attached to any object with the dust generator script on it via the inspector.
 The time between spawns affects the time between each dust particle spawning.

*/
