<template>
  <div>
    <h2>Edit Favorite</h2>
    <form v-if="like" @submit.prevent="submit">
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
      <button class="btn btn-primary">Save</button>
    </form>
  </div>
</template>

<script>
import axios from 'axios'
export default {
  data() {
    return {
      like: null
    }
  },
  mounted() {
    axios.get(`/api/Product/like/${this.$route.params.id}`).then(res => {
      this.like = res.data
    })
  },
  methods: {
    submit() {
      axios.put(`/api/Product/${this.like.sn}`, this.like).then(() => {
        this.$router.push('/')
      })
    }
  }
}
</script>
