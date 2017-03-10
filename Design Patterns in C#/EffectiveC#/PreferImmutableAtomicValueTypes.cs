//------------------------------------------------------------------------------
Immutable types are simple: After they are created, they are constant. If
	you validate the parameters used to construct the object, you know that it
		is in a valid state from that point forward. You cannot change the object’s
		internal state to make it invalid. You save yourself a lot of otherwise necessary
		error checking by disallowing any state changes after an object has
		been constructed

		An address is a single thing, composed of multiple related fields.
		A change in one field likely means changes to other fields. A customer type
		is not an atomic type. A customer type will likely contain many pieces of
		information: an address, a name, and one or more phone numbers. Any of
		these independent pieces of information might change. A customer might
		change phone numbers without moving. A customer might move, yet still
		keep the same phone number. A customer might change his or her name
		without moving or changing phone numbers. A customer object is not
		atomic; it is built from many different immutable types using composition:
	an address, a name, or a collection of phone number/type pairs

//------------------------------------------------------------------------------


