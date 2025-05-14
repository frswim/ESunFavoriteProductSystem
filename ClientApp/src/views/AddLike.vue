<template>
  <div>
    <h2>Add Favorite</h2>
    <form @submit.prevent="submit">
      <div class="mb-2">
        <label>Product No</label>
        <input v-model="like.productNo" class="form-control" />
      </div>
      <div class="mb-2">
        <label>Order Number</label>
        <input v-model="like.orderNumber" class="form-control" />
      </div>
      <div class="mb-2">
        <label>Account</label>
        <input v-model="like.account" class="form-control" />
      </div>
      <div class="mb-2">
        <label>Total Amount</label>
        <input v-model="like.totalAmount" class="form-control" />
      </div>
      <div class="mb-2">
        <label>Total Fee</label>
        <input v-model="like.totalFee" class="form-control" />
      </div>
      <button class="btn btn-success">Submit</button>
    </form>
  </div>
</template>

<script>
import axios from 'axios'
export default {
  data() {
    return {
      like: {
        productNo: '',
        orderNumber: '',
        account: '',
        totalAmount: '',
        totalFee: '',
        userID: 'A1236456789'
      }
    }
  },
  methods: {
    submit() {
      axios.post('/api/Product', this.like).then(() => {
        this.$router.push('/')
      })
    }
  }
}
</script>
