<template>
  <div>
    <button class="btn btn-primary mb-3" @click="$router.push('/add')">Add Favorite</button>
    <table class="table table-bordered">
      <thead>
        <tr>
          <th>Product</th>
          <th>Quantity</th>
          <th>Account</th>
          <th>Total Amount</th>
          <th>Fee</th>
          <th>Email</th>
          <th>Actions</th>
        </tr>
      </thead>
      <tbody>
        <tr v-for="item in likes" :key="item.sn">
          <td>{{ item.product.productName }}</td>
          <td>{{ item.orderNumber }}</td>
          <td>{{ item.account }}</td>
          <td>{{ item.totalAmount }}</td>
          <td>{{ item.totalFee }}</td>
          <td>{{ item.user.email }}</td>
          <td>
            <button class="btn btn-sm btn-warning me-1" @click="edit(item.sn)">Edit</button>
            <button class="btn btn-sm btn-danger" @click="remove(item.sn)">Delete</button>
          </td>
        </tr>
      </tbody>
    </table>
  </div>
</template>

<script>
import axios from 'axios'

export default {
  data() {
    return {
      likes: [],
      userId: 'A1236456789'
    }
  },
  methods: {
    fetchLikes() {
      axios.get(`/api/Product/${this.userId}`).then(res => {
        this.likes = res.data
      })
    },
    edit(id) {
      this.$router.push(`/edit/${id}`)
    },
    remove(id) {
      axios.delete(`/api/Product/${id}`).then(() => this.fetchLikes())
    }
  },
  mounted() {
    this.fetchLikes()
  }
}
</script>
