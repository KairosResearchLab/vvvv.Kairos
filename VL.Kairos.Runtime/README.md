# VL.Kairos.Runtime

## AlchemX
AlchemX is a library dedicated to value synthesis. It includes functionalities for value interpolation, blending and compositing.

### Available synthesis operations:
- Interpolation : produce a new value that transitions from `A` to `B` using an input `Scalar`
- Blending : produce a new value that is the result of a blending algorithm betwen a `Background` and a `Foreground` (think image blending modes : Add, Subtract, Screen, etc)
- Compositing : produce a new value that transitions from `A` to `B` using a blending model. See it as Interpolation + Blending.