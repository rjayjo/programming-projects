package com.example.atriumorderapp_mobdevtfinals.dataClass

import android.os.Parcel
import android.os.Parcelable


data class Meal(
    val imageResId: Int,
    val meallabel: String,
    val price: Int,
    var quantity: Int = 0,
    var orderTotal: Int = 0,
): Parcelable {
    constructor(parcel: Parcel) : this(
        parcel.readInt(),
        parcel.readString() ?: "",
        parcel.readInt(),
        parcel.readInt(),
        parcel.readInt()
    )

    override fun writeToParcel(parcel: Parcel, flags: Int) {
        parcel.writeInt(imageResId)
        parcel.writeString(meallabel)
        parcel.writeInt(price)
        parcel.writeInt(quantity)
        parcel.writeInt(orderTotal)
    }

    override fun describeContents(): Int {
        return 0
    }

    companion object CREATOR : Parcelable.Creator<Meal> {
        override fun createFromParcel(parcel: Parcel): Meal {
            return Meal(parcel)
        }

        override fun newArray(size: Int): Array<Meal?> {
            return arrayOfNulls(size)
        }
    }
}
